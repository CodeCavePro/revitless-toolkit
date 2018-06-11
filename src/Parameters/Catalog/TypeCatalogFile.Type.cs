using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeCave.Revit.Toolkit.Parameters.Catalog
{
    public sealed partial class TypeCatalogFile
    {
        public class Type
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Type"/> class.
            /// </summary>
            protected Type() {}

            /// <summary>
            /// Initializes a new instance of the <see cref="Type" /> class.
            /// </summary>
            /// <param name="name">Name of the type.</param>
            /// <param name="parameters">The parameters.</param>
            /// <exception cref="ArgumentException">typeName</exception>
            /// <exception cref="ArgumentNullException">parameters</exception>
            public Type(string name, IEnumerable<IParameterWithValue> parameters)
            {
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));
                if (null == parameters) throw new ArgumentNullException(nameof(parameters));

                Name = name;
                Parameters = new List<IParameterWithValue>(parameters);
            }

            /// <summary>
            /// Gets or sets the name of the type.
            /// </summary>
            /// <value>
            /// The name of the type.
            /// </value>
            public string Name { get; protected set; }

            /// <summary>
            /// Gets the parameters.
            /// </summary>
            /// <value>
            /// The parameters.
            /// </value>
            public IReadOnlyList<IParameterWithValue> Parameters { get; } = new List<IParameterWithValue>();
        }

        public class TypeCollection : List<Type>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="T:CodeCave.Revit.Toolkit.Parameters.Catalog.TypeCatalogFile.TypeCollection" /> class.
            /// </summary>
            /// <inheritdoc />
            internal TypeCollection()
            {
            }

            /// <summary>
            /// Adds the specified type.
            /// </summary>
            /// <param name="type">The type to add.</param>
            /// <exception cref="ArgumentNullException">type</exception>
            /// <exception cref="ArgumentException">type - Type</exception>
            public new void Add(Type type)
            {
                if (type == null) throw new ArgumentNullException(nameof(type));
                if (string.IsNullOrWhiteSpace(type.Name))
                    throw new ArgumentException(
                        nameof(type), $"{nameof(Type)}.{nameof(Type.Name)} must be a non-empty string!"
                    );

                if(this.Any(t => Equals(t.Name, type.Name)))
                    throw new ArgumentException(
                        nameof(type), 
                        $"A type with {nameof(Type)}.{nameof(Type.Name)}={type.Name} is already present in the list"
                    );

                base.Add(type);
            }

            /// <summary>
            /// Adds the specified type name.
            /// </summary>
            /// <param name="typeName">Name of the type.</param>
            /// <param name="parameters">The parameters.</param>
            public void Add(string typeName, IEnumerable<IParameterWithValue> parameters)
            {
                Add(new Type(typeName, parameters));
            }

            /// <summary>
            /// Adds the range of types.
            /// </summary>
            /// <param name="types">The types to add.</param>
            /// <exception cref="ArgumentNullException">types</exception>
            public new void AddRange(IEnumerable<Type> types)
            {
                if (types == null) throw new ArgumentNullException(nameof(types));

                foreach (var type in types)
                {
                    Add(type);
                }
            }
        }
    }
}
