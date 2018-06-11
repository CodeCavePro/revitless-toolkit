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
        /// Represents the entries of the *PARAM section of a shared parameter file
        /// </summary>
        /// <seealso cref="T:CodeCave.Revit.Toolkit.Parameters.IDefinition" />
        /// <seealso cref="T:CodeCave.Revit.Toolkit.Parameters.IParameter" />
        /// <inheritdoc cref="IDefinition" />
        /// <inheritdoc cref="IParameter" />
        /// <seealso cref="IEquatable{SharedParameterFile}" />
        [DebuggerDisplay("Name = {Name}   Guid = {Guid}   Value = {ValueString}   Group = {Group?.Id}   Type = {ParameterType}")]
        public class Parameter<TValue> : ParameterDefinition, IParameterWithValue
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Shared.SharedParameterFile.Parameter" /> class.
            /// </summary>
            /// <param name="guid">The unique identifier of the parameter.</param>
            /// <param name="name">The name of the parameter.</param>
            /// <param name="group">The group parameter belongs to.</param>
            /// <param name="type">The parameter type.</param>
            /// <param name="value">The value.</param>
            /// <param name="dataCategory">The data category.</param>
            /// <param name="description">The description.</param>
            /// <param name="isVisible">if set to <c>true</c> [is visible].</param>
            /// <param name="userModifiable">if set to <c>true</c> [is user modifiable].</param>
            /// <inheritdoc />
            public Parameter(
                Guid guid,
                string name,
                Group group,
                ParameterType type,
                TValue value,
                string dataCategory = "",
                string description = "",
                bool isVisible = true,
                bool userModifiable = true
            ) 
                : base(guid, name, group, type, dataCategory, description, isVisible, userModifiable)
            {
                ValueRaw = value;
            }

            /// <inheritdoc />
            /// <summary>
            /// Gets the raw value.
            /// </summary>
            /// <value>
            /// The raw value.
            /// </value>
            public object ValueRaw { get; protected set; }

            /// <summary>
            /// Gets or sets the value.
            /// </summary>
            /// <value>
            /// The value.
            /// </value>
            public TValue Value
            {
                get => (TValue) ValueRaw;
                set => ValueRaw = value;
            }

            /// <inheritdoc />
            /// <summary>
            /// Gets the value.
            /// </summary>
            /// <value>
            /// The value.
            /// </value>
            public string ValueString => ValueRaw?.ToString();

            /// <inheritdoc />
            /// <summary>
            /// To the definition.
            /// </summary>
            /// <returns></returns>
            /// <exception cref="T:System.NotImplementedException"></exception>
            public IDefinition ToDefinition()
            {
                return new ParameterDefinition(
                    Guid, Name, Group, ParameterType, 
                    DataCategory, Description, IsVisible, UserModifiable
                );
            }

            /// <inheritdoc />
            /// <summary>
            /// Creates a new object that is a copy of the current instance.
            /// </summary>
            /// <returns>
            /// A new object that is a copy of this instance.
            /// </returns>
            /// <exception cref="T:System.NotImplementedException"></exception>
            object ICloneable.Clone()
            {
                return Clone();
            }

            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns></returns>
            public Parameter<TValue> Clone()
            {
                return new Parameter<TValue>(
                    Guid, Name, Group, ParameterType, Value, 
                    DataCategory, Description, IsVisible, UserModifiable
                );
            }
        }
    }
}
