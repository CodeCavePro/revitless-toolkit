using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeCave.Revit.Toolkit.Parameters.Shared
{
    /// <summary>
    /// This class represents Revit shared parameter file
    /// </summary>
    public sealed partial class SharedParameterFile
    {
        private static readonly Regex SectionRegex;
        private static readonly CsvConfiguration CsvConfiguration;

        /// <summary>
        /// Initializes the <see cref="SharedParameterFile"/> class.
        /// </summary>
        static SharedParameterFile()
        {
            SectionRegex = new Regex(@"\*(?<section>[A-Z]+)\t", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            CsvConfiguration = new CsvConfiguration
            {
                HasHeaderRecord = true,
                AllowComments = true,
                IgnoreBlankLines = true,
                Delimiter = "\t",
                WillThrowOnMissingField = false,
                DetectColumnCountChanges = false,
            };
        }

        /// <summary>
        /// Gets or sets the meta-data section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The meta-data section of the shared parameter file.
        /// </value>
        public Meta Metadata { get; set; } = new Meta { Version = 2, MinVersion = 1 };

        /// <summary>
        /// Gets or sets the groups section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The groups section of the shared parameter file.
        /// </value>
        public List<Group> Groups { get; set; } = new List<Group>();

        /// <summary>
        /// Gets or sets the parameters section of the shared parameter file.
        /// </summary>
        /// <value>
        /// The parameters section of the shared parameter file.
        /// </value>
        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        /// <summary>
        /// Extracts <see cref="SharedParameterFile"/> object from a .txt file.
        /// </summary>
        /// <param name="sharedParameterFile">The shared parameter file path.</param>
        /// <returns>The shared parameter file</returns>
        /// <exception cref="ArgumentException"></exception>
        public static SharedParameterFile FromFile(string sharedParameterFile)
        {
            if (!File.Exists(sharedParameterFile))
            {
                throw new ArgumentException($"The following parameter file doesn't exist: '{sharedParameterFile}'");
            }

            var sharedParamsText = File.ReadAllText(sharedParameterFile);
            return FromText(sharedParamsText);
        }

        /// <summary>
        /// Extracts <see cref="SharedParameterFile"/> object from a string.
        /// </summary>
        /// <param name="sharedParameterText">Text content of shared parameter file.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">sharedParameterText</exception>
        public static SharedParameterFile FromText(string sharedParameterText)
        {
            if (string.IsNullOrWhiteSpace(sharedParameterText))
            {
                throw new ArgumentException($"{nameof(sharedParameterText)} must be a non empty string");
            }

            var sharedParamsFileLines = SectionRegex
                .Split(sharedParameterText)
                ?.Where(line => !line.StartsWith("#")) // Exclude comment lines
                ?.ToArray();

            var sharedParamsFileSections = sharedParamsFileLines
                ?.Where((e, i) => i % 2 == 0)
                ?.Select((e, i) => new { Key = e, Value = sharedParamsFileLines[i * 2 + 1] })
                ?.ToDictionary(kp => kp.Key, kp => kp.Value.Replace($"{kp.Key}\t", string.Empty));

            var sharedParamsFile = new SharedParameterFile();
            foreach (var section in sharedParamsFileSections)
            {
                using (var stringReader = new StringReader(section.Value))
                {
                    using (var csvReader = new CsvReader(stringReader, CsvConfiguration))
                    {
                        switch (section.Key)
                        {
                            case Sections.Meta:
                                csvReader.Configuration.RegisterClassMap<MetaClassMap>();
                                sharedParamsFile.Metadata = csvReader.GetRecords<Meta>().FirstOrDefault();
                                break;

                            case Sections.Groups:
                                csvReader.Configuration.RegisterClassMap<GroupClassMap>();
                                sharedParamsFile.Groups = csvReader.GetRecords<Group>().ToList();
                                break;

                            case Sections.Params:
                                csvReader.Configuration.RegisterClassMap<ParameterClassMap>();
                                sharedParamsFile.Parameters = csvReader.GetRecords<Parameter>().ToList();
                                break;
                        }
                    }
                }
            }

            // Post-process parameters by assigning group names using group IDs
            // and recover UnitType from ParameterType
            sharedParamsFile.Parameters = sharedParamsFile
                .Parameters
                .Select(p =>
                {
                    p.GroupName = sharedParamsFile?.Groups?.FirstOrDefault(g => g.ID == p.Group)?.Name;
                    p.UnitType = p.ParameterType.GetUnitType();
                    return p;
                })
                .ToList();

            return sharedParamsFile;
        }
    }
}
