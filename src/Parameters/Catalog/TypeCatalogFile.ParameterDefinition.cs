using System;
using System.Diagnostics;
using System.Linq;

namespace CodeCave.Revit.Toolkit.Parameters.Catalog
{
    public sealed partial class TypeCatalogFile
    {
        [DebuggerDisplay("Name = {Name}   Type = {ParameterType}   UnitType = {UnitType}   DisplayUnitType = {DisplayUnitType}")]
        public class ParameterDefinition : IDefinition, ICloneable
        {
            #region Constructors

            /// <summary>
            /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
            /// </summary>
            internal ParameterDefinition()
            {
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ParameterDefinition" /> class.
            /// </summary>
            /// <param name="name">The name of the parameter.</param>
            /// <param name="type">The type of the parameter.</param>
            /// <param name="displayUnits">The display units.</param>
            /// <exception cref="ArgumentException">
            /// name
            /// or
            /// type
            /// or
            /// units
            /// or
            /// displayUnits.
            /// </exception>
            public ParameterDefinition
            (
                string name,
                ParameterType type,
                DisplayUnitType displayUnits)
            {
                Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException(nameof(name));
                ParameterType = (ParameterType.Invalid != type) ? type : throw new ArgumentException(nameof(type));
                DisplayUnitType = (DisplayUnitType.DUT_UNDEFINED != displayUnits) ? displayUnits : throw new ArgumentException(nameof(displayUnits));
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
            /// </summary>
            /// <param name="name">The name of the parameter.</param>
            /// <param name="type">The type of the parameter.</param>
            /// <exception cref="ArgumentException">
            /// name
            /// or
            /// type
            /// or
            /// type - ParameterType.
            /// </exception>
            protected ParameterDefinition
            (
                string name,
                ParameterType type)
            {
                Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException(nameof(name));
                ParameterType = (ParameterType.Invalid != type) ? type : throw new ArgumentException(nameof(type));

                if (!ParameterType.TryGetDisplayForParameterType(out var displayUnits) || displayUnits.Count != 1)
                    throw new ArgumentException(
                        nameof(type),
                        $"{nameof(ParameterType)} you have specified ({type}) cannot be used to determine " +
                        $"{nameof(DisplayUnitType)} value. Please use constructor with {nameof(DisplayUnitType)} parameter");

                DisplayUnitType = displayUnits.First();
            }

            #endregion

            #region Properties

            /// <summary>
            /// Gets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
            /// <inheritdoc />
            public string Name { get; internal set; }

            /// <summary>
            /// Gets the type of the unit.
            /// </summary>
            /// <value>
            /// The type of the unit.
            /// </value>
            /// <inheritdoc />
            public UnitType UnitType => ParameterType.GetUnitType();

            /// <summary>
            /// Gets the type of the parameter.
            /// </summary>
            /// <value>
            /// The type of the parameter.
            /// </value>
            /// <inheritdoc />
            public ParameterType ParameterType { get; internal set; } = ParameterType.Invalid;

            /// <summary>
            /// Gets the display type of the unit.
            /// </summary>
            /// <value>
            /// The display type of the unit.
            /// </value>
            public DisplayUnitType DisplayUnitType { get; internal set; } = DisplayUnitType.DUT_UNDEFINED;

            /// <summary>
            /// Gets the parameter group.
            /// </summary>
            /// <value>
            /// The parameter group.
            /// </value>
            /// <inheritdoc />
            public BuiltInParameterGroup ParameterGroup => !string.IsNullOrWhiteSpace(Name) && Name.FromEnglishLabel(out var builtInParameterGroup)
                ? builtInParameterGroup
                : BuiltInParameterGroup.INVALID;

            #endregion

            #region Methods

            /// <inheritdoc />
            /// <summary>
            /// Creates a new object that is a copy of the current instance.
            /// </summary>
            /// <returns>
            /// A new object that is a copy of this instance.
            /// </returns>
            object ICloneable.Clone()
            {
                return Clone();
            }

            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns></returns>
            public ParameterDefinition Clone()
            {
                return new ParameterDefinition(Name, ParameterType, DisplayUnitType);
            }

            /// <summary>
            /// Returns a <see cref="string" /> that represents this instance.
            /// </summary>
            /// <returns>
            /// A <see cref="string" /> that represents this instance.
            /// </returns>
            public override string ToString()
            {
                var paramTypeString = ParameterType.GetUnitType().TryGetCatalogString(out var paramType)
                    ? paramType
                    : "OTHER";

                var displayUnitString = DisplayUnitType.TryGetCatalogString(out var displayUnitCatalog)
                    ? displayUnitCatalog
                    : string.Empty;

                return $"{Name}##{paramTypeString}##{displayUnitString}";
            }

            #endregion
        }
    }
}
