using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace CodeCave.Revit.Toolkit.Parameters.Catalog
{
    public sealed partial class TypeCatalogFile
    {
        [DebuggerDisplay("Name = {Name}   Value = {ValueString}   Type = {ParameterType}   UnitType = {UnitType}   DisplayUnitType = {DisplayUnitType}")]
        public class Parameter<TValue> : ParameterDefinition, IParameterWithValue
        {
            #region Constructors

            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="Parameter{TValue}"/> class.
            /// </summary>
            /// <param name="name">The name of the parameter.</param>
            /// <param name="type">The type of the parameter.</param>
            /// <param name="displayUnits">The display units.</param>
            /// <param name="value">The value of the parameter.</param>
            /// <exception cref="T:System.ArgumentException">
            /// name
            /// or
            /// type
            /// or
            /// units
            /// or
            /// displayUnits.
            /// </exception>
            public Parameter
            (
                string name,
                ParameterType type,
                TValue value,
                DisplayUnitType displayUnits) 
                : base(name, type, displayUnits)
            {
                ValueRaw = value;
            }

            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="Parameter{TValue}"/> class.
            /// </summary>
            /// <param name="name">The name of the parameter.</param>
            /// <param name="type">The type of the parameter.</param>
            /// <param name="value">The value of the parameter.</param>
            /// <exception cref="T:System.ArgumentException">
            /// name
            /// or
            /// type
            /// or
            /// type - ParameterType.
            /// </exception>
            public Parameter
            (
                string name,
                ParameterType type,
                TValue value) 
                : base(name, type)
            {
                ValueRaw = value;
            }

            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="Parameter{TValue}"/> class.
            /// </summary>
            /// <param name="name">The name.</param>
            /// <param name="value">The value.</param>
            /// <exception cref="T:System.ArgumentException">value - Value.</exception>
            public Parameter
            (
                string name,
                TValue value)
            {
                Name = name;
                ValueRaw = value;

                switch (ValueRaw)
                {
                    case bool _:
                        ParameterType = ParameterType.YesNo;
                        break;
                   
                    case short _:
                    case int _:
                    case long _:
                    case ushort _:
                    case ulong _:
                    case uint _:
                        ParameterType = ParameterType.Number;
                        break;

                    default:
                        throw new ArgumentException(
                            nameof(value),
                            $"{nameof(Value)} you have specified ({value}) cannot be used to determine " +
                            $"{nameof(ParameterType)} value. Please use constructor with {nameof(ParameterType)} parameter");
                }
            }

            /// <inheritdoc />
            /// <summary>
            /// Initializes a new instance of the <see cref="Parameter{TValue}"/> class.
            /// </summary>
            /// <param name="definition">The definition.</param>
            /// <param name="value">The value.</param>
            public Parameter(ParameterDefinition definition, TValue value) 
                : base(definition.Name, definition.ParameterType, definition.DisplayUnitType)
            {
                ValueRaw = value;
            }

            #endregion

            #region Value

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
                get => (TValue)ValueRaw;
                set => ValueRaw = value;
            }

            /// <inheritdoc />
            /// <summary>
            /// Gets the value as string.
            /// </summary>
            public virtual string ValueString
            {
                get => GetValue();
                set => ValueRaw = value;
            }

            public IDefinition ToDefinition()
            {
                return new ParameterDefinition
                {
                    Name = Name,
                    ParameterType = ParameterType,
                    DisplayUnitType = DisplayUnitType,
                };
            }

            /// <summary>
            /// Gets the value as string.
            /// </summary>
            /// <returns></returns>
            public string GetValue()
            {
                var numberFormat = CsvConfiguration.CultureInfo.NumberFormat;
                switch (ValueRaw)
                {
                    case bool boolean:
                        return (boolean ? 1 : 0).ToString("0", CultureInfo.InvariantCulture);

                    // Decimal numbers
                    case float _:
                    case double _:
                    case decimal _:
                        return decimal.Parse(ValueRaw.ToString()).ToString("#.000000000000", numberFormat);
                    
                    // Escape strings and string representations containing double quotes
                    // for example <some "string"> will serialize as <"some ""string""">
                    case string stringValue when stringValue.Contains('"'):
                    case var _ when ValueRaw?.ToString().Contains('"') ?? false:
                        return $"\"{ValueRaw?.ToString().Replace("\"", "\"\"")}\"";

                    // Escape strings and string representations containing comas
                    // for example <this, that> will serialize as <"this, that">
                    case string stringValue when stringValue.Contains(','):
                    case var _ when ValueRaw?.ToString().Contains(',') ?? false:
                        return $"\"{ValueRaw}\"";
                }

                return ValueRaw?.ToString();
            }

            #endregion

            #region ToString

            /// <inheritdoc />
            /// <summary>
            /// Returns a <see cref="T:System.String" /> that represents this instance.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that represents this instance.
            /// </returns>
            public override string ToString()
            {
                return GetValue();
            }

            #endregion

            #region Clone

            /// <summary>
            /// Clones this instance.
            /// </summary>
            /// <returns></returns>
            public new Parameter<TValue> Clone()
            {
                return new Parameter<TValue>(Name, ParameterType, Value, DisplayUnitType);
            }

            #endregion
        }
    }
}
