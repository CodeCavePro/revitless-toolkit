using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace CodeCave.Revit.Toolkit.Parameters.Shared
{
    /// <summary>
    /// This class represents Revit shared parameter file
    /// </summary>
    /// <inheritdoc cref="ICloneable" />
    /// <inheritdoc cref="IEquatable{SharedParameterFile}" />
    /// <seealso cref="System.ICloneable" />
    /// <seealso cref="System.IEquatable{SharedParameterFile}" />
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
        /// CSVHelper mappings for META section
        /// </summary>
        /// <seealso cref="T:CsvHelper.Configuration.ClassMap`1" />
        /// <inheritdoc />
        internal sealed class MetaClassMap : ClassMap<Meta>
        {
            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Shared.MetaClassMap" /> class.
            /// </summary>
            public MetaClassMap()
            {
                Map(m => m.Version).Name("VERSION");
                Map(m => m.MinVersion).Name("MINVERSION");
            }
        }

        /// <summary>
        /// CSVHelper mappings for GROUP section
        /// </summary>
        /// <seealso cref="T:CsvHelper.Configuration.ClassMap`1" />
        /// <inheritdoc />
        internal sealed class GroupClassMap : ClassMap<Group>
        {
            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Shared.GroupClassMap" /> class.
            /// </summary>
            public GroupClassMap()
            {
                Map(m => m.Id).Name("ID");
                Map(m => m.Name).Name("NAME");
            }
        }

        /// <summary>
        /// CSVHelper mappings for PARAM section
        /// </summary>
        /// <seealso cref="!:CsvHelper.Configuration.ClassMap{CodeCave.Revit.Toolkit.Parameters.Shared.Parameter}" />
        /// <inheritdoc />
        internal sealed class ParameterClassMap : ClassMap<Parameter>
        {
            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Shared.ParameterClassMap" /> class.
            /// </summary>
            public ParameterClassMap()
            {
                // "Visible" fields
                Map(m => m.Guid).Name("GUID").TypeConverter<GuidConverter>();
                Map(m => m.Name).Name("NAME");
                Map(m => m.ParameterType).Name("DATATYPE").TypeConverter<ParameterTypeConverter>();
                Map(m => m.DataCategory).Name("DATACATEGORY");
                Map(m => m.GroupId).Name("GROUP");
                Map(m => m.IsVisible).Name("VISIBLE").TypeConverter<AdvancedBooleanConverter>();
                Map(m => m.Description).Name("DESCRIPTION");
                Map(m => m.UserModifiable).Name("USERMODIFIABLE").TypeConverter<AdvancedBooleanConverter>();

                // Ignored fields
                Map(m => m.UnitType).Ignore();
                Map(m => m.DisplayUnitType).Ignore();
                Map(m => m.ParameterGroup).Ignore();
                Map(m => m.GroupName).Ignore();
            }

            /// <inheritdoc />
            /// <summary>
            /// Ensures a correct conversion of <see cref="ParameterType"/> values to/from their relative string representations
            /// </summary>
            /// <seealso cref="ITypeConverter" />
            internal class ParameterTypeConverter : ITypeConverter
            {
                /// <inheritdoc />
                /// <summary>
                /// Converts the string to an object.
                /// </summary>
                /// <param name="text">The string to convert to an object.</param>
                /// <param name="row">The <see cref="T:CsvHelper.ICsvReaderRow" /> for the current record.</param>
                /// <param name="propertyMapData">The <see cref="T:CsvHelper.Configuration.CsvPropertyMapData" /> for the property/field being created.</param>
                /// <returns>
                /// The object created from the string.
                /// </returns>
                public object ConvertFromString(string text, IReaderRow row, MemberMapData propertyMapData)
                {
                    return text.FromSharedDataType();
                }

                /// <inheritdoc />
                /// <summary>
                /// Converts the object to a string.
                /// </summary>
                /// <param name="value">The object to convert to a string.</param>
                /// <param name="row">The <see cref="T:CsvHelper.ICsvWriterRow" /> for the current record.</param>
                /// <param name="propertyMapData">The <see cref="T:CsvHelper.Configuration.CsvPropertyMapData" /> for the property/field being written.</param>
                /// <returns>
                /// The string representation of the object.
                /// </returns>
                public string ConvertToString(object value, IWriterRow row, MemberMapData propertyMapData)
                {
                    var parameterType = (ParameterType)value;
                    return parameterType.ToSharedDataType();
                }
            }

            /// <inheritdoc />
            /// <summary>
            /// A specialized CSV field value converter.
            /// Helps to serialize <see cref="bool"/> properties of <see cref="Parameter"/> object correctly.
            /// </summary>
            /// <seealso cref="CsvHelper.TypeConversion.BooleanConverter" />
            internal class AdvancedBooleanConverter : BooleanConverter
            {
                /// <inheritdoc />
                /// <summary>
                /// Converts the object to a string.
                /// </summary>
                /// <param name="value">The object to convert to a string.</param>
                /// <param name="row">The <see cref="T:CsvHelper.ICsvWriterRow" /> for the current record.</param>
                /// <param name="propertyMapData">The <see cref="T:CsvHelper.Configuration.CsvPropertyMapData" /> for the property/field being written.</param>
                /// <returns>
                /// The string representation of the object.
                /// </returns>
                public override string ConvertToString(object value, IWriterRow row, MemberMapData propertyMapData)
                {
                    if (string.IsNullOrWhiteSpace(value?.ToString()))
                        return "0";

                    return (bool.TryParse(value.ToString(), out var boolValue) && boolValue) ? "1" : "0";
                }
            }
        }
    }
}
