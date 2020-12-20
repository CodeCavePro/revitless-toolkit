using CodeCave.Revit.Toolkit.Parameters;
using System;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    [DebuggerDisplay("Name = {Name}, Value = {Value}, Units = {Units}")]
    public class PartAtomParameter : IParameterWithValue
    {
        public PartAtomParameter()
        {
        }

        public PartAtomParameter(string name, ParameterType parameterType, BuiltInParameterGroup parameterGroup, DisplayUnitType displayUnits)
            : this()
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Please provide a valid parameter name", nameof(name));

            Name = name;
            ParameterType = parameterType;
            ParameterGroup = parameterGroup;
            DisplayUnitType = displayUnits;
            UnitType = DisplayUnitType.TryGetUnitType(out var unitTypes)
                ? unitTypes.FirstOrDefault()
                : UnitType.UT_Undefined;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [XmlAttribute("type")]
        public string Type { get; internal set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlText]
        public string ValueString
        {
            get
            {
                var result = ValueRaw?.ToString();
                if (string.IsNullOrWhiteSpace(result) || !DisplayUnitType.TryGetUnitSymbolType(out var unitSymbols))
                    return result;

                unitSymbols.ForEach(ut =>
                {
                    if (ut.TryGetSymbol(out var symbol))
                        result = result.Replace(symbol, string.Empty).Trim();
                });

                return result;
            }
        }

        /// <summary>
        /// Gets the raw value.
        /// </summary>
        /// <value>
        /// The raw value.
        /// </value>
        [XmlIgnore]
        public object ValueRaw
        {
            get;
            internal set;
        }

        public string Name { get; set; }

        public UnitType UnitType { get; set; }

        public DisplayUnitType DisplayUnitType { get; set; }

        public BuiltInParameterGroup ParameterGroup { get; set; }

        public ParameterType ParameterType { get; set; }

        public IDefinition ToDefinition()
        {
            return new Definition
            {
                Name = Name,
                ParameterType = ParameterType,
                UnitType = UnitType,
            };
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        private class Definition : IDefinition
        {
            public string Name { get; set; }

            public UnitType UnitType { get; set; }

            public BuiltInParameterGroup ParameterGroup { get; set; }

            public ParameterType ParameterType { get; set; }
        }
    }
}
