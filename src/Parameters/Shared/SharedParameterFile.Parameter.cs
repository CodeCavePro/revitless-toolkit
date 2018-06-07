using System;

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
    }
}
