using System;
using System.Collections.Generic;

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
    }
}
