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
        #region Constructors

        private static readonly Configuration CsvConfiguration;
        internal IReadOnlyList<IDefinition> parameterDefinitions;
        internal TypeCollection types = new TypeCollection();

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
                    if (!header.Any() && csvReader.Read() && csvReader.ReadHeader())
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
                        var parameters = new List<IParameterWithValue>(record.Skip(1).Select((value, index) => new Parameter<object>(
                            parameterDefinitions[index] as ParameterDefinition,
                            value
                        )));
                        var type = new Type(typeName, parameters);
                        types.Add(type);
                    }
                }
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the types.
        /// </summary>
        /// <value>
        /// The types.
        /// </value>
        public IReadOnlyCollection<Type> Types => types;

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        /// <value>
        /// The encoding.
        /// </value>
        public Encoding Encoding { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        public void Add(Type type)
        {
            types.Add(type);
            if (parameterDefinitions == null && type.Parameters != null)
                parameterDefinitions = new List<IDefinition>(type.Parameters.Select(p => p.ToDefinition()));
        }

        /// <summary>
        /// Adds the specified type name.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <param name="parameters">The parameters.</param>
        public void Add(string typeName, ICollection<IParameterWithValue> parameters)
        {
            types.Add(typeName, parameters);
            if (parameterDefinitions == null && parameters != null)
                parameterDefinitions = new List<IDefinition>(parameters.Select(p => p.ToDefinition()));
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
                textWriter.WriteLine($",{string.Join(",", parameterDefinitions.Select(p => p.ToString()))}");
                foreach (var type in Types)
                {
                    textWriter.WriteLine($"{type.Name},{string.Join(",", type.Parameters.Select(p => p.ValueString))}");
                }
            }

            return catalogTypeString.ToString();
        }

        /// <summary>
        /// Saves type catalog file to specified file.
        /// </summary>
        /// <param name="pathToFile">The path to a type catalog file.</param>
        /// <param name="throwOnError">if set to <c>true</c> [throw an Exception on error].</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">pathToFile</exception>
        public bool Save(string pathToFile, bool throwOnError = false)
        {
            if (string.IsNullOrWhiteSpace(pathToFile) || Path.GetInvalidFileNameChars().Concat(Path.GetInvalidPathChars()).Any(pathToFile.Contains))
                throw new ArgumentException($"{nameof(pathToFile)} must contain a valid path to a file");

            try
            {
                File.WriteAllText(pathToFile, ToString(), Encoding ?? Encoding.UTF8);
                return true;
            }
            catch
            {
                if (throwOnError) throw;
                return false;
            }
        }

        #endregion
    }
}
