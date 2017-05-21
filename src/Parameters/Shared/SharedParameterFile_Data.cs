using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;

namespace CodeCave.Revit.Toolkit.Parameters.Shared
{
    public sealed partial class SharedParameterFile
    {
        internal struct Sections
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

        internal sealed class MetaClassMap : CsvClassMap<Meta>
        {
            public MetaClassMap()
            {
                Map(m => m.Version).Name("VERSION");
                Map(m => m.MinVersion).Name("MINVERSION");
            }
        }

        public class Group
        {
            public int ID { get; set; }

            public string Name { get; set; }
        }

        internal sealed class GroupClassMap : CsvClassMap<Group>
        {
            public GroupClassMap()
            {
                Map(m => m.ID).Name("ID");
                Map(m => m.Name).Name("NAME");
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

            public string DataCategory { get; set; } = "";

            public bool IsVisible { get; set; } = true;

            public string Description { get; set; } = "";

            public bool UserModifiable { get; set; } = true;
        }

        internal sealed class ParameterClassMap : CsvClassMap<Parameter>
        {
            public ParameterClassMap()
            {
                Map(m => m.Guid).Name("GUID");
                Map(m => m.Name).Name("NAME");
                Map(m => m.ParameterType).Name("DATATYPE").TypeConverter<ParameterTypeConverter>();
                Map(m => m.DataCategory).Name("DATACATEGORY");
                Map(m => m.Group).Name("GROUP");
                Map(m => m.IsVisible).Name("VISIBLE").TypeConverter<BooleanConverter>();
                Map(m => m.Description).Name("DESCRIPTION");
                Map(m => m.UserModifiable).Name("USERMODIFIABLE").TypeConverter<BooleanConverter>();

                Map(m => m.UnitType).Ignore();
                Map(m => m.DisplayUnitType).Ignore();
                Map(m => m.ParameterGroup).Ignore();
                Map(m => m.GroupName).Ignore();
            }

            internal class ParameterTypeConverter : ITypeConverter
            {
                public object ConvertFromString(string text, ICsvReaderRow row, CsvPropertyMapData propertyMapData)
                {
                    return text.FromSharedDataType();
                }

                public string ConvertToString(object value, ICsvWriterRow row, CsvPropertyMapData propertyMapData)
                {
                    var parameterType = (ParameterType)value;
                    return parameterType.ToSharedDataType();
                }
            }
        }
    }
}
