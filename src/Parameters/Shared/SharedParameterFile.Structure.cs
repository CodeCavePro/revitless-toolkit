using System;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                QuoteNoFields = true
            };

#if !NET452
            // Allow the usage of ANSI encoding other than the default one 
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif
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

        #region Metadata

        /// <summary>
        /// Represents the entry of the *META section of a shared parameter file
        /// </summary>
        /// <inheritdoc />
        public class MetaData : IEquatable<MetaData>
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

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            /// true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.
            /// </returns>1
            /// <inheritdoc />
            public bool Equals(MetaData other)
            {
                return null != other && Version.Equals(other.Version) && MinVersion.Equals(other.MinVersion);
            }

            /// <summary>
            /// Determines whether the specified <see cref="object" />, is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
            /// <returns>
            ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
            /// </returns>
            public override bool Equals(object obj)
            {
                return !(obj is null) &&
                       (
                           ReferenceEquals(this, obj) ||
                           obj.GetType() == GetType() && Equals(obj as Group)
                       );
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
                    return (Version * 397) ^ MinVersion;
                }
            }
        }

        #endregion Metadata

        #region Group

        /// <summary>
        /// Represents the entries of the *GROUP section of a shared parameter file
        /// </summary>
        /// <seealso cref="T:System.IEquatable`1" />
        /// <inheritdoc />
        public class Group : IEquatable<Group>
        {
            /// <summary>
            /// Gets or sets the identifier of the group.
            /// </summary>
            /// <value>
            /// The identifier of the group.
            /// </value>
            public int Id { get; set; }

            /// <summary>
            /// Gets or sets the name of the group.
            /// </summary>
            /// <value>
            /// The name of the group.
            /// </value>
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            /// true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.
            /// </returns>
            /// <inheritdoc />
            public bool Equals(Group other)
            {
                return null != other && Id.Equals(other.Id) && Name.Equals(other.Name);
            }

            /// <summary>
            /// Determines whether the specified <see cref="object" />, is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
            /// <returns>
            ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
            /// </returns>
            public override bool Equals(object obj)
            {
                return !(obj is null) &&
                       (
                           ReferenceEquals(this, obj) || 
                           obj.GetType() == GetType() && Equals(obj as Group)
                       );
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
                    var hashCode = -1919740922;
                    hashCode = hashCode * -1521134295 + Id.GetHashCode();
                    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
                    return hashCode;
                }
            }
        }

        #endregion Group

        #region Parameter

        /// <summary>
        /// Represents the entries of the *PARAM section of a shared parameter file
        /// </summary>
        /// <seealso cref="T:CodeCave.Revit.Toolkit.Parameters.IDefinition" />
        /// <seealso cref="T:CodeCave.Revit.Toolkit.Parameters.IParameter" />
        /// <inheritdoc cref="IDefinition" />
        /// <inheritdoc cref="IParameter" />
        /// <seealso cref="IEquatable{SharedParameterFile}" />
        public class Parameter : IDefinition, IParameter, IEquatable<Parameter>
        {
            /// <inheritdoc />
            /// <summary>
            /// Gets the unique identifier.
            /// </summary>
            /// <value>
            /// The unique identifier.
            /// </value>
            public Guid Guid { get; set; } = Guid.Empty;

            /// <inheritdoc />
            /// <summary>
            /// Gets a value indicating whether parameter is shared.
            /// </summary>
            /// <value>
            /// <c>true</c> if this parameter is shared; otherwise, <c>false</c>.
            /// </value>
            public bool IsShared => true;

            /// <inheritdoc />
            /// <summary>
            /// Gets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; set; }

            /// <inheritdoc />
            /// <summary>
            /// Gets the type of the unit.
            /// </summary>
            /// <value>
            /// The type of the unit.
            /// </value>
            public UnitType UnitType { get; internal set; } = UnitType.UT_Undefined;

            /// <inheritdoc />
            /// <summary>
            /// Gets the parameter group.
            /// </summary>
            /// <value>
            /// The parameter group.
            /// </value>
            public BuiltInParameterGroup ParameterGroup { get; set; } = BuiltInParameterGroup.INVALID;

            /// <inheritdoc />
            /// <summary>
            /// Gets the type of the parameter.
            /// </summary>
            /// <value>
            /// The type of the parameter.
            /// </value>
            public ParameterType ParameterType { get; set; } = ParameterType.Invalid;

            /// <inheritdoc />
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
            public int GroupId { get; set; } = -1;

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

            /// <summary>
            /// Determines whether the specified <see cref="object" />, is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
            /// <returns>
            ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
            /// </returns>
            public override bool Equals(object obj)
            {
                return !(obj is null) && (ReferenceEquals(this, obj) || Equals(obj as Parameter));
            }

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            /// true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.
            /// </returns>
            /// <inheritdoc />
            public bool Equals(Parameter other)
            {
                return null != other && (Guid.Equals(other.Guid) &&
                                         Name.Equals(other.Name) &&
                                         IsShared.Equals(other.IsShared) &&
                                         Description.Equals(other.Description) &&
                                         (GroupId.Equals(other.GroupId) || GroupName.Equals(other.GroupName)));
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
                    var hashCode = Guid.GetHashCode();
                    hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (int) UnitType;
                    hashCode = (hashCode * 397) ^ (int) ParameterGroup;
                    hashCode = (hashCode * 397) ^ (int) ParameterType;
                    hashCode = (hashCode * 397) ^ (int) DisplayUnitType;
                    hashCode = (hashCode * 397) ^ GroupId;
                    hashCode = (hashCode * 397) ^ (DataCategory != null ? DataCategory.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ IsVisible.GetHashCode();
                    hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ UserModifiable.GetHashCode();
                    return hashCode;
                }
            }
        }

        #endregion Parameter
    }
}
