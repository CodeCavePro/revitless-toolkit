using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
        [DebuggerDisplay("Name = {Name}   Guid = {Guid}   Group = {Group?.Id}   Type = {ParameterType}")]
        public class ParameterDefinition : IDefinition, IParameter, IEquatable<ParameterDefinition>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Parameter"/> class.
            /// </summary>
            protected ParameterDefinition() {}

            /// <summary>
            /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Shared.SharedParameterFile.Parameter" /> class.
            /// </summary>
            /// <param name="guid">The unique identifier of the parameter.</param>
            /// <param name="name">The name of the parameter.</param>
            /// <param name="group">The group parameter belongs to.</param>
            /// <param name="type">The parameter type.</param>
            /// <param name="dataCategory">The data category.</param>
            /// <param name="description">The description.</param>
            /// <param name="isVisible">if set to <c>true</c> [is visible].</param>
            /// <param name="userModifiable">if set to <c>true</c> [is user modifiable].</param>
            /// <inheritdoc />
            public ParameterDefinition(
                Guid guid,
                string name,
                Group group,
                ParameterType type,
                string dataCategory = "",
                string description = "",
                bool isVisible = true,
                bool userModifiable = true
            ) : this()
            {
                Guid = guid;
                Name = name;
                Group = group;
                ParameterType = type;
                DataCategory = dataCategory;
                Description = description;
                IsVisible = isVisible;
                UserModifiable = userModifiable;
            }

            /// <inheritdoc />
            /// <summary>
            /// Gets the unique identifier.
            /// </summary>
            /// <value>
            /// The unique identifier.
            /// </value>
            public Guid Guid { get; protected set; } = Guid.Empty;

            /// <inheritdoc />
            /// <summary>
            /// Gets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            public string Name { get; protected set; }

            /// <inheritdoc />
            /// <summary>
            /// Gets the type of the unit.
            /// </summary>
            /// <value>
            /// The type of the unit.
            /// </value>
            public UnitType UnitType => ParameterType.GetUnitType();

            /// <inheritdoc />
            /// <summary>
            /// Gets the parameter group.
            /// </summary>
            /// <value>
            /// The parameter group.
            /// </value>
            public BuiltInParameterGroup ParameterGroup => BuiltInParameterGroup.INVALID;

            /// <inheritdoc />
            /// <summary>
            /// Gets the type of the parameter.
            /// </summary>
            /// <value>
            /// The type of the parameter.
            /// </value>
            public ParameterType ParameterType { get; protected set; } = ParameterType.Invalid;

            /// <inheritdoc />
            /// <summary>
            /// Gets the display type of the unit.
            /// </summary>
            /// <value>
            /// The display type of the unit.
            /// </value>
            public DisplayUnitType DisplayUnitType => DisplayUnitType.DUT_UNDEFINED;

            /// <summary>
            /// Gets or sets the group.
            /// </summary>
            /// <value>
            /// The group object.
            /// </value>
            public Group Group { get; set; }

            /// <summary>
            /// Gets or sets the data category.
            /// https://knowledge.autodesk.com/support/revit-products/troubleshooting/caas/sfdcarticles/sfdcarticles/Why-the-DATACATEGORY-column-is-empty-in-shared-parameter-txt-file.html
            /// </summary>
            /// <value>
            /// The data category.
            /// </value>
            public string DataCategory { get; protected set; } = "";

            /// <inheritdoc />
            /// <summary>
            /// Gets a value indicating whether parameter is shared.
            /// </summary>
            /// <value>
            /// <c>true</c> if this parameter is shared; otherwise, <c>false</c>.
            /// </value>
            public bool IsShared => true;

            /// <summary>
            /// Gets or sets a value indicating whether this instance is visible.
            /// </summary>
            /// <value>
            ///   <c>true</c> if this instance is visible; otherwise, <c>false</c>.
            /// </value>
            public bool IsVisible { get; protected set; } = true;

            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            /// <value>
            /// The description.
            /// </value>
            public string Description { get; protected set; } = "";

            /// <summary>
            /// Gets or sets a value indicating whether [user modifiable].
            /// </summary>
            /// <value>
            ///   <c>true</c> if [user modifiable]; otherwise, <c>false</c>.
            /// </value>
            public bool UserModifiable { get; protected set; } = true;

            /// <summary>
            /// Determines whether the specified <see cref="object" />, is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
            /// <returns>
            ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
            /// </returns>
            public override bool Equals(object obj)
            {
                return !(obj is null) && (ReferenceEquals(this, obj) || Equals(obj as ParameterDefinition));
            }

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            /// true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.
            /// </returns>
            /// <inheritdoc />
            public bool Equals(ParameterDefinition other)
            {
                return null != other && Equals(Guid, other.Guid) &&
                                        Equals(Name, other.Name) &&
                                        Equals(UnitType, other.UnitType) &&
                                        Equals(ParameterGroup, other.ParameterGroup) &&
                                        Equals(ParameterType, other.ParameterType) &&
                                        Equals(DisplayUnitType, other.DisplayUnitType) &&
                                        Equals(Group, other.Group) &&
                                        Equals(DataCategory, other.DataCategory) &&
                                        Equals(IsVisible, other.IsVisible) &&
                                        Equals(Description, other.Description) &&
                                        Equals(UserModifiable, other.UserModifiable);
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
                    hashCode = (hashCode * 397) ^ (Group != null ? Group.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ (DataCategory != null ? DataCategory.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ IsVisible.GetHashCode();
                    hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode() : 0);
                    hashCode = (hashCode * 397) ^ UserModifiable.GetHashCode();
                    return hashCode;
                }
            }
        }


        /// <summary>
        /// A collection of parameter entries tied to a specific <see cref="SharedParameterFile"/> parent
        /// </summary>
        /// <seealso cref="T:System.Collections.Generic.List`1" />
        /// <inheritdoc />
        public class ParameterCollection : List<ParameterDefinition>
        {
            protected readonly SharedParameterFile parameterFile;

            /// <summary>
            /// Initializes a new instance of the <see cref="ParameterCollection" /> class.
            /// </summary>
            /// <param name="parameterFile">The parent parameter file.</param>
            /// <param name="parameters">The parameters.</param>
            /// <exception cref="T:System.ArgumentNullException">parameterFile</exception>
            /// <inheritdoc />
            public ParameterCollection(SharedParameterFile parameterFile, IEnumerable<ParameterDefinition> parameters)
                :base(parameters ?? new List<ParameterDefinition>())
            {
                this.parameterFile = parameterFile ?? throw new ArgumentNullException(nameof(parameterFile));
            }

            public new void Add(ParameterDefinition parameter)
            {
                if (parameter == null) throw new ArgumentNullException(nameof(parameter));
                if (parameter.Group == null) throw new ArgumentNullException(
                    nameof(parameter), $"Parameter you have provided has no {nameof(ParameterDefinition.Group)} assigned"
                );
                if (parameter.Guid == null) throw new ArgumentNullException(
                    nameof(parameter), $"Parameter you have provided has no {nameof(ParameterDefinition.Guid)} assigned"
                );

                if (this.Any(p => Equals(parameter.Guid, p.Guid))) throw new ArgumentException(
                    nameof(parameter),
                    $"You are trying to add a parameter with {nameof(ParameterDefinition.Guid)}={parameter.Guid} value already used by another parameter in the collection"
                );

                if (this.Any(p => Equals(parameter.Name, p.Name))) throw new ArgumentException(
                    nameof(parameter),
                    $"You are trying to add a parameter with {nameof(ParameterDefinition.Guid)}={parameter.Guid} value already used by another parameter in the collection"
                );

                if (parameterFile.Groups.Any(g => Equals(g.Id, parameter.Group?.Id) && !Equals(g.Name, parameter.Group?.Name))) throw new ArgumentException(
                    nameof(parameter),
                    $"You are trying to add a parameter with {nameof(Group)}.{nameof(Group.Id)}={parameter.Group.Id} value already used by another group in {nameof(Groups)} collection"
                );

                if (parameterFile.Groups.Any(g => Equals(g.Name, parameter.Group?.Name) && !Equals(g.Id, parameter.Group?.Id))) throw new ArgumentException(
                    nameof(parameter),
                    $"You are trying to add a parameter with {nameof(Group)}.{nameof(Group.Name)}={parameter.Group.Name} value already used by another group in {nameof(Groups)} collection"
                );

                base.Add(parameter);
            }

            /// <summary>
            /// Adds the range of parameters.
            /// </summary>
            /// <param name="parameters">The parameters.</param>
            /// <exception cref="ArgumentNullException">parameters</exception>
            public new void AddRange(IEnumerable<ParameterDefinition> parameters)
            {
                if (parameters == null) throw new ArgumentNullException(nameof(parameters));

                foreach (var parameter in parameters)
                {
                    Add(parameter);
                }
            }

            /// <summary>
            /// Adds the specified unique identifier.
            /// </summary>
            /// <param name="guid">The unique identifier.</param>
            /// <param name="name">The name.</param>
            /// <param name="groupName">Name of the group.</param>
            /// <param name="type">The type.</param>
            /// <param name="dataCategory">The data category.</param>
            /// <param name="description">The description.</param>
            /// <param name="isVisible">if set to <c>true</c> [is visible].</param>
            /// <param name="userModifiable">if set to <c>true</c> [user modifiable].</param>
            /// <exception cref="ArgumentNullException">groupName</exception>
            public void Add(
                Guid guid,
                string name,
                string groupName,
                ParameterType type,
                string dataCategory = "",
                string description = "",
                bool isVisible = true,
                bool userModifiable = true
            )
            {
                if (string.IsNullOrWhiteSpace(groupName)) throw new ArgumentNullException(nameof(groupName));

                var group =
                    parameterFile.Groups.FirstOrDefault(g => Equals(groupName, g.Name)) ??
                    new Group(groupName, parameterFile.Groups.Count + 1);

                Add(
                    guid, name, group, type,
                    dataCategory, description,
                    isVisible, userModifiable
                );
            }

            /// <summary>
            /// Adds the specified unique identifier.
            /// </summary>
            /// <param name="guid">The unique identifier.</param>
            /// <param name="name">The name.</param>
            /// <param name="group">The group.</param>
            /// <param name="type">The type.</param>
            /// <param name="dataCategory">The data category.</param>
            /// <param name="description">The description.</param>
            /// <param name="isVisible">if set to <c>true</c> [is visible].</param>
            /// <param name="userModifiable">if set to <c>true</c> [user modifiable].</param>
            /// <exception cref="ArgumentNullException">
            /// name
            /// or
            /// group
            /// </exception>
            public void Add(
                Guid guid,
                string name,
                Group group,
                ParameterType type,
                string dataCategory = "",
                string description = "",
                bool isVisible = true,
                bool userModifiable = true
            )
            {
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
                if (@group == null) throw new ArgumentNullException(nameof(@group));

                Add(new ParameterDefinition(
                    guid,
                    name,
                    group,
                    type,
                    dataCategory,
                    description,
                    isVisible,
                    userModifiable
                ));
            }
        }
    }
}
