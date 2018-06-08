using CsvHelper;
using CsvHelper.Configuration;
using System;
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
    [DebuggerDisplay("Metadata = {Metadata.Version}.{Metadata.MinVersion}   Groups = {Groups?.Count}   Parameters = {Parameters?.Count}")]
    public sealed partial class SharedParameterFile : ICloneable, IEquatable<SharedParameterFile>, IValidatableObject
    {
        #region Constructors

        private List<Group> _groups;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedParameterFile"/> class.
        /// </summary>
        /// <param name="groups">The list of groups.</param>
        /// <param name="parameters">The list of parameters.</param>
        /// <param name="metadata">The metadata section.</param>
        public SharedParameterFile(IEnumerable<Group> groups = null, IEnumerable<Parameter> parameters = null, MetaData metadata = null)
        {
            Metadata = metadata ?? new MetaData(2, 1);
            Parameters = new ParameterCollection(this, parameters ?? new List<Parameter>());
            _groups = groups != null ? new List<Group>(groups) : new List<Group>();
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

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        /// <value>
        /// The encoding.
        /// </value>
        public Encoding Encoding { get; } = Encoding.UTF8;

        /// <summary>
        /// Gets or sets the meta-data section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The meta-data section of the shared parameter file.
        /// </value>
        public MetaData Metadata { get; } = new MetaData(2, 1);

        /// <summary>
        /// Gets the group items from *GROUP section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The groups section of the shared parameter file.
        /// </value>
        public IReadOnlyList<Group> Groups
        {
            get
            {
                return new HashSet<Group>((_groups ?? new List<Group>()).Concat(Parameters.Where(p => null != p.Group).Select(p => p.Group))).ToList();
            }
            private set => _groups = (null != value) ? new List<Group>(value) : null;
        }

        /// <summary>
        /// Gets or sets the parameters section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The parameters section of the shared parameter file.
        /// </value>
        public ParameterCollection Parameters { get; }

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

            var groups = Groups.ToArray();
            if (!groups.Any())
                results.Add(new ValidationResult("The list of groups is empty", new[] {nameof(Groups)}));

            if (!Parameters.Any())
                results.Add(new ValidationResult("The list of parameters is empty", new[] {nameof(Parameters)}));

            // Check for group duplicates by ID
            var groupIds = groups.GroupBy(p => p.Id).Where(g => g.Count() > 1).Select(p => p.Key);
            results.AddRange(groupIds.Select(groupId =>
                new ValidationResult($"The following group {nameof(Group.Id)} has duplicates: {groupId}",
                    new[] {nameof(Groups)})));

            // Check for group duplicates by name
            var groupNames = groups.GroupBy(p => p.Name).Where(g => g.Count() > 1).Select(p => p.Key);
            results.AddRange(groupNames.Select(group =>
                new ValidationResult($"The following group {nameof(Group.Name)} has duplicates: {group}",
                    new[] {nameof(Groups)})));

            // Check for unused
            var unusedGroups = groups.Where(g => !Parameters.Any(p => g.Id.Equals(p.Group?.Id)));
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
            var paramGroupOrphans = Parameters.Where(p => !groups.Any(g => g.Id.Equals(p.Group?.Id)));
            results.AddRange(paramGroupOrphans.Select(p =>
                new ValidationResult($"The following parameter is assigned to an unknown group ({p.Group?.Id}): {p.Name}",
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
            return !(obj is null) && (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals(obj as SharedParameterFile));
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

            return Equals(Parameters?.Count, other.Parameters?.Count) &&
                   Equals(Parameters?.Count, Parameters?.Intersect(other.Parameters ?? new List<Parameter>()).Count());
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
                hashCode = hashCode * -1521134295 + EqualityComparer<IReadOnlyList<Group>>.Default.GetHashCode(Groups);
                hashCode = hashCode * -1521134295 + EqualityComparer<ParameterCollection>.Default.GetHashCode(Parameters);
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
            return Clone(false);
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public SharedParameterFile Clone()
        {
            return Clone(false);
        }

        /// <summary>
        /// Clones the file.
        /// </summary>
        /// <param name="randomize">if set to <c>true</c> [randomize].</param>
        /// <returns></returns>
        internal SharedParameterFile Clone(bool randomize)
        {
            var clone = new SharedParameterFile
            (
                _groups,
                randomize
                    ? Parameters.OrderBy(x => Guid.NewGuid()).ToList()
                    : Parameters.ToList(),
                new MetaData(Metadata)
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
            var metaAsString = SectionToCsv<MetaClassMap, MetaData>(Sections.META, new[] { Metadata });
            output.AppendLine(metaAsString);

            // Serialize GROUP entries to CSV
            var groupsAsString = SectionToCsv<GroupClassMap, Group>(Sections.GROUPS, Groups);
            output.AppendLine(groupsAsString);

            // Serialize PARAM entries to CSV
            var paramsAsString = SectionToCsv<ParameterClassMap, Parameter>(Sections.PARAMS, Parameters);
            output.AppendLine(paramsAsString);

            return output.ToString();
        }

        /// <summary>
        /// Serializes shared parameter file's sections to CSV.
        /// </summary>
        /// <typeparam name="TCsvMap">CSV class mappings</typeparam>
        /// <typeparam name="TEntries">Type of entries to serialize</typeparam>
        /// <param name="sectionName">Name of the section.</param>
        /// <param name="sectionEntries">Section entries.</param>
        /// <returns></returns>
        private static string SectionToCsv<TCsvMap, TEntries>(string sectionName, IEnumerable<TEntries> sectionEntries)
            where TCsvMap : ClassMap<TEntries>
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