using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeCave.Revit.Toolkit.Parameters.Shared
{
    public sealed partial class SharedParameterFile
    {
        private static readonly Regex SectionRegex;
        private static readonly CsvConfiguration CsvConfiguration;

        static SharedParameterFile()
        {
            SectionRegex = new Regex(@"\*(?<section>[A-Z]+)\t", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            CsvConfiguration = new CsvConfiguration
            {
                HasHeaderRecord = true,
                AllowComments = true,
                IgnoreBlankLines = true,
                Delimiter = "\t",
                WillThrowOnMissingField = false,
                DetectColumnCountChanges = false,
            };
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

            var sharedParamsFileLines = SectionRegex
                .Split(sharedParameterText)
                ?.Where(line => !line.StartsWith("#")) // Exclude comment lines
                ?.ToArray();

            var sharedParamsFileSections = sharedParamsFileLines
                ?.Where((e, i) => i % 2 == 0)
                ?.Select((e, i) => new { Key = e, Value = sharedParamsFileLines[i * 2 + 1] })
                ?.ToDictionary(kp => kp.Key, kp => kp.Value.Replace($"{kp.Key}\t", string.Empty));

            var sharedParamsFile = new SharedParameterFile();
            foreach (var section in sharedParamsFileSections)
            {
                using (var stringReader = new StringReader(section.Value))
                {
                    using (var csvReader = new CsvReader(stringReader, CsvConfiguration))
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

            // Post-process parameters by assigning group names using group IDs
            // and recover UnitType from ParameterType
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
    }
}
