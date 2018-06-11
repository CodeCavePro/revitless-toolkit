using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace CodeCave.Revit.Toolkit.Parameters.Catalog
{
    public sealed partial class TypeCatalogFile
    {
        private static readonly Configuration CsvConfiguration;
        internal IReadOnlyList<ParameterDefinition> parameterDefinitions;

        /// <summary>
        /// Initializes the <see cref="TypeCatalogFile"/> class.
        /// </summary>
        static TypeCatalogFile()
        {
            CsvConfiguration = new Configuration
            {
                HasHeaderRecord = true,
                AllowComments = true,
                IgnoreBlankLines = true,
                Delimiter = ",",
                DetectColumnCountChanges = false,
                QuoteNoFields = true,
                IncludePrivateMembers = true,
                TrimOptions = TrimOptions.Trim,
                CultureInfo = new CultureInfo("en-US"),
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeCatalogFile"/> class.
        /// </summary>
        public TypeCatalogFile() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeCatalogFile"/> class.
        /// </summary>
        /// <param name="typeCatalogFile">The type catalog file.</param>
        /// <param name="encoding">The encoding.</param>
        /// <exception cref="ArgumentException">typeCatalogFile</exception>
        public TypeCatalogFile(string typeCatalogFile, Encoding encoding = null)
        {
            if (string.IsNullOrWhiteSpace(typeCatalogFile))
            {
                throw new ArgumentException($"{nameof(typeCatalogFile)} must be a non empty string");
            }

            if (File.Exists(typeCatalogFile))
            {
                Encoding = encoding ?? new FileInfo(typeCatalogFile).GetEncoding();
                typeCatalogFile = File.ReadAllText(typeCatalogFile, Encoding);
            }

            typeCatalogFile = typeCatalogFile.TrimStart(',');

            using (var stringReader = new StringReader(typeCatalogFile))
            {
                using (var csvReader = new CsvReader(stringReader, CsvConfiguration))
                {
                    string[] header = { };
                    while (csvReader.Read() && csvReader.ReadHeader() && !header.Any())
                    {
                        header = csvReader.Context.HeaderRecord;
                    }

                    parameterDefinitions = header
                        .Select(h =>
                        {
                            var headerParts = h.Split(new []{ "##" }, 3, StringSplitOptions.None);
                            if (!headerParts.Any() || 3 != headerParts.Length)
                            {
                                throw new InvalidDataException(
                                    "Type catalog's header must consists of the following 3 parts: " +
                                    "{ParameterName}##{ParameterType}##{ParameterUnits}"
                                );
                            }

                            var name = headerParts.ElementAt(0);
                            var units = headerParts.ElementAt(1).TryGetUnitTypeFromCatalogString(out var unitType)
                                ? unitType
                                : UnitType.UT_Undefined;
                            var type = units.TryGetParameterType(out var paramType)
                                ? paramType
                                : ParameterType.Invalid;
                            var displayUnits = headerParts.ElementAt(2).TryGetFromCatalogString(out var displayUnitType)
                                ? displayUnitType
                                : DisplayUnitType.DUT_UNDEFINED;

                            return new ParameterDefinition
                            {
                                Name = name,
                                ParameterType = type,
                                DisplayUnitType = displayUnits
                            };
                        })
                        .ToList();

                    while (csvReader.Read())
                    {
                        var record = csvReader.Context.Record;
                        var typeName = record.First();
                        var parameters = new List<Parameter<object>>(record.Skip(1).Select((value, index) => new Parameter<object>(parameterDefinitions[index], value)));
                        var type = new Type(typeName, parameters);
                        Types.Add(type);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the types.
        /// </summary>
        /// <value>
        /// The types.
        /// </value>
        private TypeCollection Types { get; } = new TypeCollection();

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        /// <value>
        /// The encoding.
        /// </value>
        public Encoding Encoding { get; }

        /// <summary>
        /// Adds the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        public void Add(Type type)
        {
            Types.Add(type);
            if (parameterDefinitions == null && type.Parameters != null)
                parameterDefinitions = new List<ParameterDefinition>(type.Parameters.Cast<ParameterDefinition>());
        }

        /// <summary>
        /// Adds the specified type name.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <param name="parameters">The parameters.</param>
        public void Add(string typeName, ICollection<IParameterWithValue> parameters)
        {
            Types.Add(typeName, parameters);
            if (parameterDefinitions == null && parameters != null)
                parameterDefinitions = new List<ParameterDefinition>(parameters.Cast<ParameterDefinition>());
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var catalogTypeString = new StringBuilder();
            using (var textWriter = new StringWriter(catalogTypeString))
            {
                textWriter.WriteLine($",{string.Join(",", parameterDefinitions)}");
                foreach (var type in Types)
                {
                    textWriter.WriteLine($"{type.Name},{string.Join(",", type.Parameters.Select(p => p.ValueString))}");
                }
            }

            return catalogTypeString.ToString();
        }
    }
}
