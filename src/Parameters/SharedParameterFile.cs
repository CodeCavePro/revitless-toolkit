using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeCave.Revit.Toolkit.Parameters
{
    public class SharedParameterFile
    {
        private static readonly Regex SectionRegex;

        static SharedParameterFile()
        {
            SectionRegex = new Regex(@"\*(?<section>[A-Z]+)\t", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        public Meta Metadata { get; set; } = new Meta { Version = 2, MinVersion = 1 };

        public List<Group> Groups { get; set; } = new List<Group>();

        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        public static SharedParameterFile FromFile(string sharedParameterFile)
        {
            if (!File.Exists(sharedParameterFile))
            {
                throw new ArgumentException($"The following parameter file doesn't exist: '{sharedParameterFile}'");
            }

            var sharedParamsText = File.ReadAllText(sharedParameterFile);
            return FromText(sharedParamsText);
        }

        public static SharedParameterFile FromText(string sharedParameterText)
        {
            if (string.IsNullOrWhiteSpace(sharedParameterText))
            {
                throw new ArgumentException($"{nameof(sharedParameterText)} must be a non empty string");
            }

            var sharedParamsFile = new SharedParameterFile();

            var blocks = SectionRegex
                .Split(sharedParameterText)
                ?.Where(line => !line.StartsWith("#"))
                ?.ToArray();

            var sections = blocks
                ?.Where((e, i) => i % 2 == 0)
                ?.Select((e, i) => new { Key = e, Value = blocks[i * 2 + 1] })
                ?.ToDictionary(kp => kp.Key, kp => kp.Value.Replace($"{kp.Key}\t", string.Empty));

            var csvCofig = new CsvConfiguration
            {
                HasHeaderRecord = true,
                AllowComments = true,
                IgnoreBlankLines = true,
                Delimiter = "\t",
            };

            foreach (var section in sections)
            {
                using (var stringReader = new StringReader(section.Value))
                {
                    using (var csvReader = new CsvReader(stringReader, csvCofig))
                    {
                        switch (section.Key)
                        {
                            case Sections.Meta:
                                csvReader.Configuration.RegisterClassMap<MetaClassMap>();
                                sharedParamsFile.Metadata = csvReader.GetRecords<Meta>().FirstOrDefault();
                                break;

                            case Sections.Groups:
                                csvReader.Configuration.RegisterClassMap<GroupClassMap>();
                                sharedParamsFile.Groups = csvReader.GetRecords<Group>().ToList();
                                break;

                            case Sections.Params:
                                csvReader.Configuration.RegisterClassMap<ParameterClassMap>();
                                sharedParamsFile.Parameters = csvReader.GetRecords<Parameter>().ToList();
                                break;
                        }
                    }
                }
            }

            sharedParamsFile.Parameters = sharedParamsFile
                .Parameters
                .Select(p => 
                {
                    p.GroupName = sharedParamsFile?.Groups?.FirstOrDefault(g => g.ID == p.Group)?.Name;
                    return p;
                })
                .ToList();

            return sharedParamsFile;
        }

        public struct Sections
        {
            public const string Meta = "META";
            public const string Groups = "GROUP";
            public const string Params = "PARAM";
        }

        public class Meta
        {
            public int Version { get; set; }

            public int MinVersion { get; set; }
        }

        private sealed class MetaClassMap : CsvClassMap<Meta>
        {
            public MetaClassMap()
            {
                Map(m => m.Version).Index(0);
                Map(m => m.MinVersion).Index(1);
            }
        }

        public class Group
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        private sealed class GroupClassMap : CsvClassMap<Group>
        {
            public GroupClassMap()
            {
                Map(m => m.ID).Index(0);
                Map(m => m.Name).Index(1);
            }
        }

        public class Parameter : IDefinition, IParameter
        {
            public Guid Guid { get; set; } = Guid.Empty;

            public bool IsShared => true;

            public string Name { get; set; }

            public UnitType UnitType { get; set; } = UnitType.UT_Undefined;

            public BuiltInParameterGroup ParameterGroup { get; set; } = BuiltInParameterGroup.INVALID;

            public ParameterType ParameterType { get; set; } = ParameterType.Invalid;

            public DisplayUnitType DisplayUnitType { get; set; } = DisplayUnitType.DUT_UNDEFINED;

            public int Group { get; set; } = -1;

            public string GroupName { get; internal set; } = "";

            public bool IsVisible { get; set; } = true;

            public string Description { get; set; } = "";

            public bool UserModifiable { get; set; } = true;
        }

        private sealed class ParameterClassMap : CsvClassMap<Parameter>
        {
            public ParameterClassMap()
            {
                Map(m => m.Guid).Index(0);
                Map(m => m.Name).Index(1);
                Map(m => m.UnitType).Index(2).TypeConverter<UnitTypeConverter>();
                Map(m => m.ParameterType).Ignore();
                Map(m => m.DisplayUnitType).Ignore();
                Map(m => m.ParameterGroup).Ignore();
                Map(m => m.GroupName).Ignore();
                // Map(m => m.DataCategory).Index(3) // Skip DATACATEGORY column
                Map(m => m.Group).Index(4);
                Map(m => m.IsVisible).Index(5).TypeConverter<BooleanConverter>();
                Map(m => m.Description).Index(6);
                Map(m => m.UserModifiable).Index(7).TypeConverter<BooleanConverter>();
            }

            internal class UnitTypeConverter : ITypeConverter
            {
                public object ConvertFromString(string text, ICsvReaderRow row, CsvPropertyMapData propertyMapData)
                {
                    text.TryGetUnitType(out UnitType unitType);
                    return unitType;
                }

                public string ConvertToString(object value, ICsvWriterRow row, CsvPropertyMapData propertyMapData)
                {
                    var unitType = (UnitType)value;
                    unitType.TryGetCatalogString(out string catalogString);
                    return catalogString;
                }
            }
        }
    }
}
