using System;

namespace CodeCave.Revit.Toolkit.Parameters
{
    public interface IParameter
    {
        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        Guid Guid { get; }

        /// <summary>
        /// Gets a value indicating whether parameter is shared.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this parameter is shared; otherwise, <c>false</c>.
        /// </value>
        bool IsShared { get; }

        /// <summary>
        /// Gets the display type of the unit.
        /// </summary>
        /// <value>
        /// The display type of the unit.
        /// </value>
        DisplayUnitType DisplayUnitType { get; }
    }
}
