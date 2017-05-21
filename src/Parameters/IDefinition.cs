using System;

namespace CodeCave.Revit.Toolkit.Parameters
{
    interface IDefinition
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the type of the unit.
        /// </summary>
        /// <value>
        /// The type of the unit.
        /// </value>
        UnitType UnitType { get; }

        /// <summary>
        /// Gets the parameter group.
        /// </summary>
        /// <value>
        /// The parameter group.
        /// </value>
        BuiltInParameterGroup ParameterGroup { get; }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        /// <value>
        /// The type of the parameter.
        /// </value>
        ParameterType ParameterType { get; }
    }
}
