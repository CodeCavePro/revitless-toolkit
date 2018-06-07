using System;
using System.Diagnostics;

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
        /// <summary>
        /// Represents the entry of the *META section of a shared parameter file
        /// </summary>
        /// <inheritdoc />
        [DebuggerDisplay("Version = {Version}   MinVersion = {MinVersion}")]
        public class MetaData : IEquatable<MetaData>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="MetaData"/> class.
            /// </summary>
            protected MetaData() {}

            /// <summary>
            /// Initializes a new instance of the <see cref="MetaData"/> class.
            /// </summary>
            /// <param name="other">The other.</param>
            public MetaData(MetaData other)
            {
                Version = other.Version;
                MinVersion = other.MinVersion;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="MetaData"/> class.
            /// </summary>
            /// <param name="majorVersion">The major version.</param>
            /// <param name="minorVersion">The minor version.</param>
            public MetaData(int majorVersion, int minorVersion)
            {
                Version = majorVersion;
                MinVersion = minorVersion;
            }

            /// <summary>
            /// Gets or sets the version.
            /// </summary>
            /// <value>
            /// The version.
            /// </value>
            public int Version { get; protected set; }

            /// <summary>
            /// Gets or sets the minimum version.
            /// </summary>
            /// <value>
            /// The minimum version.
            /// </value>
            public int MinVersion { get; protected set; }

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
                return null != other && Equals(Version, other.Version) && Equals(MinVersion, other.MinVersion);
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
    }
}
