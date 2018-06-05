using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeCave.Revit.Toolkit.Parameters.Shared
{
    /// <summary>
    /// This class represents Revit shared parameter file
    /// </summary>
    /// <inheritdoc cref="ICloneable" />
    /// <inheritdoc cref="IEquatable{SharedParameterFile}" />
    /// <seealso cref="ICloneable" />
    /// <seealso cref="IEquatable{SharedParameterFile}" />
    public sealed partial class SharedParameterFile : ICloneable, IEquatable<SharedParameterFile>, IValidatableObject
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedParameterFile"/> class.
        /// </summary>
        /// <param name="metadata">The metadata section.</param>
        /// <param name="groups">The list of groups.</param>
        /// <param name="parameters">The list of parameters.</param>
        public SharedParameterFile(MetaData metadata = null, IEnumerable<Group> groups = null, IEnumerable<Parameter> parameters = null)
        {
            Metadata = metadata ?? new MetaData {Version = 2, MinVersion = 1};
            Groups = groups != null ? new List<Group>(groups) : new List<Group>();
            Parameters = parameters != null ? new List<Parameter>(parameters) : new List<Parameter>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Shared.SharedParameterFile" /> class.
        /// </summary>
        /// <param name="sharedParameterFile">The shared parameter file.</param>
        /// <param name="encoding">The encoding to use, fallbacks to UTF-8.</param>
        /// ReSharper disable once SuggestBaseTypeForParameter
        /// <inheritdoc />
        public SharedParameterFile(FileInfo sharedParameterFile, Encoding encoding = null)
            : this(sharedParameterFile?.FullName, encoding)
        {}

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
                            if (nameof(Parameter.Description).Equals(headerNames?.FirstOrDefault(), StringComparison.OrdinalIgnoreCase))
                                return;

                            // Allow USERMODIFIABLE header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.UserModifiable).Equals(headerNames?.FirstOrDefault(), StringComparison.OrdinalIgnoreCase))
                                return;

                            originalHeaderValidated(false, headerNames, headerIndex, context);
                        };

                        var originalMissingFieldFound = csvReader.Configuration.MissingFieldFound;
                        csvReader.Configuration.MissingFieldFound = (headerNames, index, context) =>
                        {
                            // Allow DESCRIPTION header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.Description).Equals(headerNames?.FirstOrDefault(), StringComparison.OrdinalIgnoreCase))
                                return;

                            // Allow USERMODIFIABLE header to be missing (it's actually missing in older shared parameter files)
                            if (nameof(Parameter.UserModifiable).Equals(headerNames?.FirstOrDefault(), StringComparison.OrdinalIgnoreCase))
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
                                Groups = csvReader.GetRecords<Group>().ToList();
                                break;

                            // Parse *PARAM section
                            case Sections.PARAMS:
                                csvReader.Configuration.RegisterClassMap<ParameterClassMap>();
                                Parameters = csvReader.GetRecords<Parameter>().ToList();
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
            Parameters = Parameters
                .AsParallel()
                .Select(p =>
                {
                    p.GroupName = Groups?.FirstOrDefault(g => g.Id == p.GroupId)?.Name;
                    p.UnitType = p.ParameterType.GetUnitType();
                    return p;
                })
                .ToList();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        /// <value>
        /// The encoding.
        /// </value>
        public Encoding Encoding { get; }

        /// <summary>
        /// Gets or sets the meta-data section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The meta-data section of the shared parameter file.
        /// </value>
        public MetaData Metadata { get; }

        /// <summary>
        /// Gets or sets the groups section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The groups section of the shared parameter file.
        /// </value>
        public List<Group> Groups { get; }

        /// <summary>
        /// Gets or sets the parameters section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The parameters section of the shared parameter file.
        /// </value>
        public List<Parameter> Parameters { get; }

        #endregion Properties

        #region Validation

        /// <summary>
        /// Returns true if shared parameter file is valid.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            var validationResults = Validate(new ValidationContext(this));
            return !validationResults.Any();
        }

        /// <summary>
        /// Determines whether the specified file is valid or not.
        /// </summary>
        /// <param name="validationContext">The validation context.</param>
        /// <returns>
        /// A collection that holds failed-validation information.
        /// </returns>
        /// <inheritdoc />
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // General health check
            if (Metadata.Version <= 0 || Metadata.MinVersion <= 0)
                results.Add(new ValidationResult($"Data in {nameof(Sections.META)} section is invalid",
                    new[] {nameof(Metadata)}));

            if (!Groups.Any())
                results.Add(new ValidationResult("The list of groups is empty", new[] {nameof(Groups)}));

            if (!Parameters.Any())
                results.Add(new ValidationResult("The list of parameters is empty", new[] {nameof(Parameters)}));

            // Check for group duplicates by ID
            var groupIds = Groups.GroupBy(p => p.Id).Where(g => g.Count() > 1).Select(p => p.Key);
            results.AddRange(groupIds.Select(groupId =>
                new ValidationResult($"The following group {nameof(Group.Id)} has duplicates: {groupId}",
                    new[] {nameof(Groups)})));

            // Check for group duplicates by name
            var groupNames = Groups.GroupBy(p => p.Name).Where(g => g.Count() > 1).Select(p => p.Key);
            results.AddRange(groupNames.Select(group =>
                new ValidationResult($"The following group {nameof(Group.Name)} has duplicates: {group}",
                    new[] {nameof(Groups)})));

            // Check for unused
            var unusedGroups = Groups.Where(g => !Parameters.Any(p => p.GroupId.Equals(g.Id)));
            results.AddRange(unusedGroups.Select(g =>
                new ValidationResult($"The following group is unused (not assigned to any parameter): {g.Id}={g.Name}",
                    new[] {nameof(Groups)})));

            // Check for parameter duplicates by Guid
            var paramGuidDuplicates = Parameters.GroupBy(p => p.Guid).Where(g => g.Count() > 1).Select(p => p.Key);
            results.AddRange(paramGuidDuplicates.Select(guid =>
                new ValidationResult($"The following parameter {nameof(Parameter.Guid)} has duplicates: {guid}",
                    new[] {nameof(Parameters)})));

            // Check for parameter duplicates by name
            var paramNameDuplicates = Parameters.GroupBy(p => p.Name).Where(g => g.Count() > 1).Select(p => p.Key);
            results.AddRange(paramNameDuplicates.Select(name =>
                new ValidationResult($"The following parameter {nameof(Parameter.Name)} has duplicates: {name}",
                    new[] {nameof(Parameters)})));

            // Check for orphan parameters by groups
            var paramGroupOrphans = Parameters.Where(p => !Groups.Any(g => g.Id.Equals(p.GroupId)));
            results.AddRange(paramGroupOrphans.Select(p =>
                new ValidationResult($"The following parameter is assigned to an unknown group ({p.GroupId}): {p.Name}",
                    new[] {nameof(Parameters)})));

            return results;
        }

        #endregion Validation

        #region Equals and GetHashCode

        /// <summary>
        /// Determines whether the specified <see cref="Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="Object" /> to compare with this instance.</param>
        /// <returns>
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals(obj as SharedParameterFile);
        }

        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.
        /// </returns>
        public bool Equals(SharedParameterFile other)
        {
            // ReSharper disable once UseNullPropagation
            if (other == null) return false;

            if (Metadata.Version != other.Metadata.Version || Metadata.MinVersion != other.Metadata.MinVersion)
                return false;

            if (Groups.Count != other.Groups.Count || Groups.Intersect(other.Groups).Count() != Groups.Count)
                return false;

            return Parameters.Count == other.Parameters.Count && Parameters.Intersect(other.Parameters).Count() == Parameters.Count;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = -409059346;
                hashCode = hashCode * -1521134295 + EqualityComparer<MetaData>.Default.GetHashCode(Metadata);
                hashCode = hashCode * -1521134295 + EqualityComparer<List<Group>>.Default.GetHashCode(Groups);
                hashCode = hashCode * -1521134295 + EqualityComparer<List<Parameter>>.Default.GetHashCode(Parameters);
                return hashCode;
            }
        }

        #endregion Equals and GetHashCode

        #region Cloning

        /// <inheritdoc />
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        object ICloneable.Clone()
        {
            return CloneFile();
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public SharedParameterFile Clone()
        {
            return CloneFile();
        }

        /// <summary>
        /// Clones the file.
        /// </summary>
        /// <param name="randomize">if set to <c>true</c> [randomize].</param>
        /// <returns></returns>
        internal SharedParameterFile CloneFile(bool randomize = false)
        {
            var clone = new SharedParameterFile
            (
                new MetaData {Version = Metadata.Version, MinVersion = Metadata.MinVersion},
                randomize
                    ? new List<Group>(Groups.OrderBy(x => Guid.NewGuid()))
                    : new List<Group>(Groups),
                randomize
                    ? new List<Parameter>(Parameters.OrderBy(x => Guid.NewGuid()))
                    : new List<Parameter>(Parameters)
            );

            return clone;
        }

        #endregion Cloning

        #region ToString

        /// <summary>
        /// Returns a <see cref="String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine("# This is a Revit shared parameter file.");
            output.AppendLine("# Do not edit manually.");

            // Serialize META to CSV
            var metaAsString = SectionToCsv<MetaClassMap>(Sections.META, new[] { Metadata });
            output.AppendLine(metaAsString);

            // Serialize GROUP entries to CSV
            var groupsAsString = SectionToCsv<GroupClassMap>(Sections.GROUPS, Groups);
            output.AppendLine(groupsAsString);

            // Serialize PARAM entries to CSV
            var paramsAsString = SectionToCsv<ParameterClassMap>(Sections.PARAMS, Parameters);
            output.AppendLine(paramsAsString);

            return output.ToString();
        }

        /// <summary>
        /// Serializes shared parameter file's sections to CSV.
        /// </summary>
        /// <typeparam name="TCsvMap">CSV class mappings</typeparam>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="sectionEntries">Section entries.</param>
        /// <returns></returns>
        private static string SectionToCsv<TCsvMap>(string sectionName, IEnumerable sectionEntries)
            where TCsvMap : ClassMap
        {
            // Serialize entries to CSV
            var sectionBuilder = new StringBuilder();
            using (var textWriter = new StringWriter(sectionBuilder))
            {
                using (var csvWriter = new CsvWriter(textWriter, CsvConfiguration))
                {
                    csvWriter.Configuration.RegisterClassMap<TCsvMap>();
                    csvWriter.WriteRecords(sectionEntries);
                }
            }

            // Prepends section lines with section name
            var sectionAsString = string.Join(Environment.NewLine,
                sectionBuilder.ToString()
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(line => $"{sectionName}\t{line}")
            );

            // Prepends asterisk as section marker
            return $"*{sectionAsString}";
        }


        #endregion ToString
    }
}