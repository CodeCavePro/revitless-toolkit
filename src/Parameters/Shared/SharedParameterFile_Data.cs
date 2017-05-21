using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;

namespace CodeCave.Revit.Toolkit.Parameters.Shared
{
    public sealed partial class SharedParameterFile
    {
        /// <summary>
        /// Defines the names of shared parameter file sections
        /// </summary>
        internal struct Sections
        {
            public const string META = "META";
            public const string GROUPS = "GROUP";
            public const string PARAMS = "PARAM";
        }

        /// <summary>
        /// Represents the entry of the *META section of a shared parameter file
        /// </summary>
        public class Meta
        {
            /// <summary>
            /// Gets or sets the version.
            /// </summary>
            /// <value>
            /// The version.
            /// </value>
            public int Version { get; set; }

            /// <summary>
            /// Gets or sets the minimum version.
            /// </summary>
            /// <value>
            /// The minimum version.
            /// </value>
            public int MinVersion { get; set; }
        }

        /// <summary>
        /// Represents the entries of the *GROUP section of a shared parameter file
        /// </summary>
        public class Group
        {
            /// <summary>
            /// Gets or sets the identifier of the group.
            /// </summary>
            /// <value>
            /// The identifier of the group.
            /// </value>
            public int ID { get; set; }

            /// <summary>
            /// Gets or sets the name of the group.
            /// </summary>
            /// <value>
            /// The name of the group.
            /// </value>
            public string Name { get; set; }
        }

        /// <summary>
        /// Represents the entries of the *PARAM section of a shared parameter file
        /// </summary>
        /// <seealso cref="IDefinition" />
        /// <seealso cref="IParameter" />
        public class Parameter : IDefinition, IParameter
        {
            /// <summary>
            /// Gets the unique identifier.
            /// </summary>
            /// <value>
            /// The unique identifier.
            /// </value>
            public Guid Guid { get; set; } = Guid.Empty;

            /// <summary>
            /// Gets a value indicating whether parameter is shared.
            /// </summary>
            /// <value>
            /// <c>true</c> if this parameter is shared; otherwise, <c>false</c>.
            /// </value>
            public bool IsShared => true;

            /// <summary>
            /// Gets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Gets the type of the unit.
            /// </summary>
            /// <value>
            /// The type of the unit.
            /// </value>
            public UnitType UnitType { get; set; } = UnitType.UT_Undefined;

            /// <summary>
            /// Gets the parameter group.
            /// </summary>
            /// <value>
            /// The parameter group.
            /// </value>
            public BuiltInParameterGroup ParameterGroup { get; set; } = BuiltInParameterGroup.INVALID;

            /// <summary>
            /// Gets the type of the parameter.
            /// </summary>
            /// <value>
            /// The type of the parameter.
            /// </value>
            public ParameterType ParameterType { get; set; } = ParameterType.Invalid;

            /// <summary>
            /// Gets the display type of the unit.
            /// </summary>
            /// <value>
            /// The display type of the unit.
            /// </value>
            public DisplayUnitType DisplayUnitType { get; set; } = DisplayUnitType.DUT_UNDEFINED;

            /// <summary>
            /// Gets or sets the group ID.
            /// </summary>
            /// <value>
            /// The group ID.
            /// </value>
            public int Group { get; set; } = -1;

            /// <summary>
            /// Gets the name of the group.
            /// </summary>
            /// <value>
            /// The name of the group.
            /// </value>
            public string GroupName { get; internal set; } = "";

            /// <summary>
            /// Gets or sets the data category.
            /// </summary>
            /// <value>
            /// The data category.
            /// </value>
            public string DataCategory { get; set; } = "";

            /// <summary>
            /// Gets or sets a value indicating whether this instance is visible.
            /// </summary>
            /// <value>
            ///   <c>true</c> if this instance is visible; otherwise, <c>false</c>.
            /// </value>
            public bool IsVisible { get; set; } = true;

            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            /// <value>
            /// The description.
            /// </value>
            public string Description { get; set; } = "";

            /// <summary>
            /// Gets or sets a value indicating whether [user modifiable].
            /// </summary>
            /// <value>
            ///   <c>true</c> if [user modifiable]; otherwise, <c>false</c>.
            /// </value>
            public bool UserModifiable { get; set; } = true;
        }

        /// <summary>
        ///
        /// </summary>
        /// <seealso cref="CsvHelper.Configuration.CsvClassMap{CodeCave.Revit.Toolkit.Parameters.Shared.SharedParameterFile.Meta}" />
        internal sealed class MetaClassMap : CsvClassMap<Meta>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="MetaClassMap"/> class.
            /// </summary>
            public MetaClassMap()
            {
                Map(m => m.Version).Name("VERSION");
                Map(m => m.MinVersion).Name("MINVERSION");
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <seealso cref="CsvClassMap{CodeCave.Revit.Toolkit.Parameters.Shared.SharedParameterFile.Group}" />
        internal sealed class GroupClassMap : CsvClassMap<Group>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="GroupClassMap"/> class.
            /// </summary>
            public GroupClassMap()
            {
                Map(m => m.ID).Name("ID");
                Map(m => m.Name).Name("NAME");
            }
        }

        internal sealed class ParameterClassMap : CsvClassMap<Parameter>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ParameterClassMap"/> class.
            /// </summary>
            public ParameterClassMap()
            {
                // "Visible" fields
                Map(m => m.Guid).Name("GUID");
                Map(m => m.Name).Name("NAME");
                Map(m => m.ParameterType).Name("DATATYPE").TypeConverter<ParameterTypeConverter>();
                Map(m => m.DataCategory).Name("DATACATEGORY");
                Map(m => m.Group).Name("GROUP");
                Map(m => m.IsVisible).Name("VISIBLE").TypeConverter<AdvancedBooleanConverter>();
                Map(m => m.Description).Name("DESCRIPTION");
                Map(m => m.UserModifiable).Name("USERMODIFIABLE").TypeConverter<AdvancedBooleanConverter>();

                // Ignored fields
                Map(m => m.UnitType).Ignore();
                Map(m => m.DisplayUnitType).Ignore();
                Map(m => m.ParameterGroup).Ignore();
                Map(m => m.GroupName).Ignore();
            }

            /// <summary>
            /// Ensures a correct conversion of <see cref="ParameterType"/> values to/from their relative string representations
            /// </summary>
            /// <seealso cref="ITypeConverter" />
            internal class ParameterTypeConverter : ITypeConverter
            {
                /// <summary>
                /// Converts the string to an object.
                /// </summary>
                /// <param name="text">The string to convert to an object.</param>
                /// <param name="row">The <see cref="T:CsvHelper.ICsvReaderRow" /> for the current record.</param>
                /// <param name="propertyMapData">The <see cref="T:CsvHelper.Configuration.CsvPropertyMapData" /> for the property/field being created.</param>
                /// <returns>
                /// The object created from the string.
                /// </returns>
                public object ConvertFromString(string text, ICsvReaderRow row, CsvPropertyMapData propertyMapData)
                {
                    return text.FromSharedDataType();
                }

                /// <summary>
                /// Converts the object to a string.
                /// </summary>
                /// <param name="value">The object to convert to a string.</param>
                /// <param name="row">The <see cref="T:CsvHelper.ICsvWriterRow" /> for the current record.</param>
                /// <param name="propertyMapData">The <see cref="T:CsvHelper.Configuration.CsvPropertyMapData" /> for the property/field being written.</param>
                /// <returns>
                /// The string representation of the object.
                /// </returns>
                public string ConvertToString(object value, ICsvWriterRow row, CsvPropertyMapData propertyMapData)
                {
                    var parameterType = (ParameterType)value;
                    return parameterType.ToSharedDataType();
                }
            }

            /// <summary>
            /// A specialized CSV field value converter.
            /// Helps to serialize <see cref="bool"/> properties of <see cref="Parameter"/> object correctly.
            /// </summary>
            /// <seealso cref="CsvHelper.TypeConversion.BooleanConverter" />
            internal class AdvancedBooleanConverter : BooleanConverter
            {
                /// <summary>
                /// Converts the object to a string.
                /// </summary>
                /// <param name="value">The object to convert to a string.</param>
                /// <param name="row">The <see cref="T:CsvHelper.ICsvWriterRow" /> for the current record.</param>
                /// <param name="propertyMapData">The <see cref="T:CsvHelper.Configuration.CsvPropertyMapData" /> for the property/field being written.</param>
                /// <returns>
                /// The string representation of the object.
                /// </returns>
                public override string ConvertToString(object value, ICsvWriterRow row, CsvPropertyMapData propertyMapData)
                {
                    if (string.IsNullOrWhiteSpace(value?.ToString()))
                        return "0";

                    return (bool.TryParse(value?.ToString(), out bool boolValue) && boolValue) ? "1" : "0";
                }
            }
        }
    }
}
