using System;

namespace CodeCave.Revit.Toolkit.Parameters
{
    public interface IParameterWithValue : IDefinition, ICloneable
    {
        /// <summary>
        /// Gets the raw value.
        /// </summary>
        /// <value>
        /// The raw value.
        /// </value>
        object ValueRaw { get; }

        /// <summary>
        /// Gets the value as string.
        /// </summary>
        /// <returns></returns>
        string ValueString { get; }

        /// <summary>
        /// To the definition.
        /// </summary>
        /// <returns></returns>
        IDefinition ToDefinition();
    }
}
