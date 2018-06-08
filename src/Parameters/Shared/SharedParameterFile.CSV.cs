using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// <seealso cref="ICloneable" />
    /// <seealso cref="IEquatable{SharedParameterFile}" />
    public sealed partial class SharedParameterFile
    {
        #region Constructor

        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private static readonly Regex SectionRegex;
        private static readonly Configuration CsvConfiguration;

        /// <summary>
        /// Initializes the <see cref="SharedParameterFile"/> class.
        /// </summary>
        static SharedParameterFile()
        {
            SectionRegex = new Regex(@"\*(?<section>[A-Z]+)\t", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            CsvConfiguration = new Configuration
            {
                HasHeaderRecord = true,
                AllowComments = true,
                IgnoreBlankLines = true,
                Delimiter = "\t",
                DetectColumnCountChanges = false,
                QuoteNoFields = true,
                IncludePrivateMembers = true
            };

#if !NET452
            // Allow the usage of ANSI encoding other than the default one 
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SharedParameterFile" /> class.
        /// </summary>
        /// <param name="sharedParameterFile">The shared parameter file.</param>
        /// <param name="encoding">The encoding to use, fallbacks to UTF-8.</param>
        /// <exception cref="ArgumentException">sharedParameterFile</exception>
        /// <exception cref="InvalidDataException">Failed to parse shared parameter file content," +
        /// "because it doesn't contain enough data for being qualified as a valid shared parameter file.</exception>
        public SharedParameterFile(string sharedParameterFile, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(sharedParameterFile))
            {
                throw new ArgumentException($"{nameof(sharedParameterFile)} must be a non empty string");
            }

            if (!SectionRegex.IsMatch(sharedParameterFile) && File.Exists(sharedParameterFile))
            {
                Encoding = encoding ?? new FileInfo(sharedParameterFile).GetEncoding();
                sharedParameterFile = File.ReadAllText(sharedParameterFile, Encoding);
            }

            var sharedParamsFileLines = SectionRegex
                .Split(sharedParameterFile)
                .Where(line => !line.StartsWith("#")) // Exclude comment lines
                .ToArray();

            var sharedParamsFileSections = sharedParamsFileLines
                .Where((e, i) => i % 2 == 0)
                .Select((e, i) => new { Key = e, Value = sharedParamsFileLines[i * 2 + 1] })
                .ToDictionary(kp => kp.Key, kp => kp.Value.Replace($"{kp.Key}\t", string.Empty));

            if (sharedParamsFileSections == null || sharedParamsFileSections.Count < 3 ||
                !(sharedParamsFileSections.ContainsKey(Sections.META) &&
                  sharedParamsFileSections.ContainsKey(Sections.GROUPS) &&
                  sharedParamsFileSections.ContainsKey(Sections.PARAMS)))
            {
                throw new InvalidDataException("Failed to parse shared parameter file content," +
                                               "because it doesn't contain enough data for being qualified as a valid shared parameter file.");
            }

            foreach (var section in sharedParamsFileSections)
            {
                using (var stringReader = new StringReader(section.Value))
                {
                    using (var csvReader = new CsvReader(stringReader, CsvConfiguration))
                    {
                        csvReader.Configuration.TrimOptions = TrimOptions.Trim;
                        csvReader.Configuration.BadDataFound = BadDataFound;

                        // TODO implement
                        // csvReader.Configuration.AllowComments = true;
                        // csvReader.Configuration.Comment = '#';

                        var originalHeaderValidated = csvReader.Configuration.HeaderValidated;
                        csvReader.Configuration.HeaderValidated = (isValid, headerNames, headerIndex, context) =>
                        {
                            // Everything is OK, just go out
                            if (isValid)
                                return;

                            // Allow DESCRIPTION header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.Description).Equals(headerNames?.FirstOrDefault(),
                                StringComparison.OrdinalIgnoreCase))
                                return;

                            // Allow USERMODIFIABLE header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.UserModifiable).Equals(headerNames?.FirstOrDefault(),
                                StringComparison.OrdinalIgnoreCase))
                                return;

                            originalHeaderValidated(false, headerNames, headerIndex, context);
                        };

                        var originalMissingFieldFound = csvReader.Configuration.MissingFieldFound;
                        csvReader.Configuration.MissingFieldFound = (headerNames, index, context) =>
                        {
                            // Allow DESCRIPTION header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.Description).Equals(headerNames?.FirstOrDefault(),
                                StringComparison.OrdinalIgnoreCase))
                                return;

                            // Allow USERMODIFIABLE header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.UserModifiable).Equals(headerNames?.FirstOrDefault(),
                                StringComparison.OrdinalIgnoreCase))
                                return;

                            originalMissingFieldFound(headerNames, index, context);
                        };

                        switch (section.Key)
                        {
                            // Parse *META section
                            case Sections.META:
                                csvReader.Configuration.RegisterClassMap<MetaClassMap>();
                                Metadata = csvReader.GetRecords<MetaData>().FirstOrDefault();
                                break;

                            // Parse *GROUP section
                            case Sections.GROUPS:
                                csvReader.Configuration.RegisterClassMap<GroupClassMap>();
                                _groups = csvReader.GetRecords<Group>().ToList();
                                break;

                            // Parse *PARAM section
                            case Sections.PARAMS:
                                csvReader.Configuration.RegisterClassMap<ParameterClassMap>();
                                Parameters = new ParameterCollection(this, csvReader.GetRecords<Parameter>().ToList());
                                break;

                            default:
                                Debug.WriteLine($"Unknown section type: {section.Key}");
                                continue;
                        }
                    }
                }
            }

            // Post-process parameters by assigning group names using group IDs 
            // and recover UnitType from ParameterType 
            Parameters = new ParameterCollection(
                this, // Parent shared parameter file
                Parameters
                    ?.AsParallel()
                    .Select(p =>
                    {
                        p.Group = _groups?.FirstOrDefault(g => g.Id == p.Group.Id);
                        return p;
                    })
                    .ToList() ?? new List<Parameter>()
                );
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Extracts <see cref="SharedParameterFile"/> object from a .txt file.
        /// </summary>
        /// <param name="sharedParameterFile">The shared parameter file path.</param>
        /// <returns>The shared parameter file</returns>
        /// <exception cref="ArgumentException"></exception>
        [Obsolete("Please use constructor instead")]
        public static SharedParameterFile FromFile(string sharedParameterFile)
        {
            return new SharedParameterFile(new FileInfo(sharedParameterFile));
        }

        /// <summary>
        /// Extracts <see cref="SharedParameterFile"/> object from a string.
        /// </summary>
        /// <param name="sharedParameterText">Text content of shared parameter file.</param>
        /// <returns>The shared parameter file</returns>
        /// <exception cref="System.ArgumentException">sharedParameterText</exception>
        [Obsolete("Please use constructor instead")]
        public static SharedParameterFile FromText(string sharedParameterText)
        {
            return new SharedParameterFile(sharedParameterText);
        }

        /// <summary>
        /// Saves shared parameter file to specified file.
        /// </summary>
        /// <param name="pathToFile">The path to the file.</param>
        /// <param name="throwOnError">if set to <c>true</c> [throw an Exception on error].</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">pathToFile</exception>
        public bool Save(string pathToFile, bool throwOnError = false)
        {
            if (string.IsNullOrWhiteSpace(pathToFile) || Path.GetInvalidFileNameChars().Concat(Path.GetInvalidPathChars()).Any(pathToFile.Contains))
                throw new ArgumentException($"{nameof(pathToFile)} must contain a valid path to a file");

            try
            {
                File.WriteAllText(pathToFile, ToString(), Encoding ?? Encoding.UTF8);
                return true;
            }
            catch
            {
                if (throwOnError) throw;
                return false;
            }
        }

        #endregion Methods

        #region Helpers

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
        /// Handles cases when invalid data raises <see cref="BadDataException"/>.
        /// </summary>
        /// <param name="readingContext">CSV parsing context.</param>
        /// <exception cref="BadDataException"></exception>
        private static void BadDataFound(ReadingContext readingContext)
        {
            if (readingContext.Field.Contains('\"')) // Allow double quotes in parameter names
            {
                return;
            }

            throw new BadDataException(readingContext, $"File contains bad / invalid data: {readingContext.Field}");
        }

        #endregion Helpers

        #region MetaClassMap

        /// <summary>
        /// CSVHelper mappings for META section
        /// </summary>
        /// <seealso cref="T:CsvHelper.Configuration.ClassMap`1" />
        /// <inheritdoc />
        internal sealed class MetaClassMap : ClassMap<MetaData>
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

        #endregion MetaClassMap

        #region GroupClassMap

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

        #endregion GroupClassMap

        #region ParameterClassMap

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
                Map(m => m.Guid).Name("GUID").TypeConverter<GuidConverter>().Index(0);
                Map(m => m.Name).Name("NAME").Index(1);
                Map(m => m.ParameterType).Name("DATATYPE").TypeConverter<ParameterTypeConverter>().Index(2);
                Map(m => m.DataCategory).Name("DATACATEGORY").Index(3);
                Map(m => m.Group.Id).Name("GROUP").Index(4);
                Map(m => m.IsVisible).Name("VISIBLE").TypeConverter<AdvancedBooleanConverter>().Index(5);
                Map(m => m.Description).Name("DESCRIPTION").Index(6);
                Map(m => m.UserModifiable).Name("USERMODIFIABLE").TypeConverter<AdvancedBooleanConverter>().Index(7);

                // Ignored fields
                Map(m => m.UnitType).Ignore();
                Map(m => m.DisplayUnitType).Ignore();
                Map(m => m.ParameterGroup).Ignore();
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

        #endregion ParameterClassMap
    }
}
