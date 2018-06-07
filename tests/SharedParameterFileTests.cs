using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CodeCave.Revit.Toolkit.Parameters.Shared;
using Xunit;

namespace CodeCave.Revit.Toolkit.Tests
{
    public class SharedParameterFileTests
    {
        private static readonly string[] SharedParameterFiles;
        private static readonly string PathToValidFiles, PathToInvalidFiles;

        /// <summary>
        /// Initializes the <see cref="SharedParameterFileTests"/> class.
        /// </summary>
        static SharedParameterFileTests()
        {
            var sharedParamFilesDir = Path.Combine(Environment.CurrentDirectory, "Resources", "SharedParameterFiles");
            PathToValidFiles = Path.Combine(sharedParamFilesDir, "Valid");
            PathToInvalidFiles = Path.Combine(sharedParamFilesDir, "Invalid");
            SharedParameterFiles = Directory.GetFiles(sharedParamFilesDir, "*.txt", SearchOption.AllDirectories);
        }

        /// <summary>
        /// Checks if shared parameter files pass validation.
        /// </summary>
        [Fact]
        public void ValidFilesPassValidation()
        {
            Assert.All(SharedParameterFiles.Where(f => f.StartsWith(PathToValidFiles)),
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    Assert.True(sharedParamFile.IsValid());
                }
            );
        }

        /// <summary>
        /// Checks if invalid file fail to pass validation.
        /// </summary>
        [Fact]
        public void InvalidFilesFailValidation()
        {
            Assert.All(SharedParameterFiles.Where(f => f.StartsWith(PathToInvalidFiles)),
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    Assert.False(sharedParamFile.IsValid());
                }
            );
        }

        /// <summary>
        /// Checks if shared parameter file's meta section is parsed correctly.
        /// </summary>
        [Fact]
        public void MetaIsParsedCorrectly()
        {
            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFileText = File.ReadAllLines(sharedParamFilePath, sharedParamFile.Encoding);
                    var metaRow = $"META\t{sharedParamFile.Metadata.Version}\t{sharedParamFile.Metadata.MinVersion}";
                    var containsMeta = sharedParamFileText.Any(line => line.Contains(metaRow));
                    Assert.True(containsMeta);
                }
            );
        }

        /// <summary>
        /// Checks if the number of parsed shared parameter's file groups is correct.
        /// </summary>
        [Fact]
        public void GroupsCountIsCorrect()
        {
            var groupLineRegex = new Regex(@"^GROUP(.+?)$",
                RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFileText = File.ReadAllText(sharedParamFilePath, sharedParamFile.Encoding);
                    var paramLineMatches = groupLineRegex.Matches(sharedParamFileText);
                    Assert.Equal(paramLineMatches.Count, sharedParamFile.Groups?.Count);
                }
            );
        }

        /// <summary>
        /// Checks if the number of parsed shared parameter's file parameters is correct.
        /// </summary>
        [Fact]
        public void ParametersCountIsCorrect()
        {
            var paramLineRegex = new Regex(@"^PARAM(.*)$",
                RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase);

            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFileText = File.ReadAllText(sharedParamFilePath, sharedParamFile.Encoding);
                    var paramLineMatches = paramLineRegex.Matches(sharedParamFileText);
                    Assert.Equal(paramLineMatches.Count, sharedParamFile.Parameters?.Count);
                }
            );
        }

        /// <summary>
        /// Checks if shared parameter file's parameters are parsed correctly.
        /// </summary>
        [Fact]
        public void ParametersAreParsedCorrectly()
        {
            var paramLineRegex = new Regex(
                @"^PARAM\t(?<guid>[({]?[a-zA-Z0-9]{8}[-]?([a-zA-Z0-9]{4}[-]?){3}[a-zA-Z0-9]{12}[})]?)\t(?<name>.*?)\t.*$",
                RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase
            );

            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFileText = File.ReadAllText(sharedParamFilePath, sharedParamFile.Encoding);
                    var paramLineMatches = paramLineRegex.Matches(sharedParamFileText);
                    var paramNames = paramLineMatches.Select(m => m.Groups["name"]?.Value.Trim()).ToArray();
                    var paramGuids = paramLineMatches.Select(m => m.Groups["guid"].Value).Select(g => new Guid(g))
                        .ToArray();
                    Assert.All(
                        sharedParamFile.Parameters,
                        param =>
                        {
                            Assert.Contains(param.Name, paramNames);
                            Assert.Contains(param.Guid, paramGuids);
                        }
                    );
                }
            );
        }

        /// <summary>
        /// Checks if shared parameter's file groups are parsed correctly.
        /// </summary>
        [Fact]
        public void GroupsAreParsedCorrectly()
        {
            var groupLineRegex = new Regex(
                @"^GROUP\t(?<id>\d+)\t(?<name>.*?)$",
                RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase
            );

            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFileText = File.ReadAllText(sharedParamFilePath, sharedParamFile.Encoding);
                    var groupLineMatches = groupLineRegex.Matches(sharedParamFileText);
                    var groupIds = groupLineMatches.Select(m => m.Groups["id"].Value).Select(int.Parse).ToArray();
                    var groupNames = groupLineMatches
                        .Select(m => m.Groups["name"].Value)
                        .Select(name => name.TrimEnd('\t', '\r'))
                        .ToArray();
                    Assert.All(
                        sharedParamFile.Groups,
                        param =>
                        {
                            Assert.Contains(param.Id, groupIds);
                            Assert.Contains(param.Name, groupNames);
                        }
                    );
                }
            );
        }

        /// <summary>
        /// Checks if a shared parameter file and it's randomized clone are equal.
        /// </summary>
        [Fact]
        public void ClonedAndRandomizedFilesAreEqual()
        {
            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile1 = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFile2 = sharedParamFile1.Clone(true);
                    Assert.True(sharedParamFile1.Equals(sharedParamFile2));
                }
            );
        }

        /// <summary>
        /// Checks if to string works correctly.
        /// </summary>
        [Fact]
        public void ToStringOutputCopyIsEqual()
        {
            Assert.All(SharedParameterFiles.Where(f => f.StartsWith(PathToValidFiles)),
                sharedParamFilePath =>
                {
                    var sharedParamFile1 = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFile2 = new SharedParameterFile(sharedParamFile1.ToString());

                    Assert.True(sharedParamFile1.Equals(sharedParamFile2));
                }
            );
        }

        /// <summary>
        /// Files the is serialized properly.
        /// </summary>
        [Fact]
        public void FileSerializedProperly()
        {
            var simpleSharedFromDisk = File
                .ReadAllText(SharedParameterFiles.FirstOrDefault(f => f.EndsWith(@"SimpleShared_1.txt")))
                .TrimEnd('\r', '\n', '\r')
                .Replace("\r\n", string.Empty)
                .Replace("\r", string.Empty)
                .Replace("\n", string.Empty);

            var simpleSharedFromBuilt = new SharedParameterFile();

            #region Identity Data

            var identityDataGroup = new SharedParameterFile.Group("Identity Data", 100);
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("61ff3d56-09d7-4049-8c78-4abe745e4e5a"), "EquipmentName",
                identityDataGroup, ParameterType.Text
            ));

            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("758c97dc-6b88-4fbd-9570-4affdc32f08d"), "EquipmentNumber",
                identityDataGroup, ParameterType.Text
            ));

            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("b5a53ea4-55d9-497c-8488-6607faa11e5f"), "EquipmentServed",
                identityDataGroup, ParameterType.Text
            ));

            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("d4fa8765-86f3-4472-860c-a906aff18593"), "EquipmentType",
                identityDataGroup, ParameterType.Text
            ));

            #endregion

            #region Dimensions

            var dimensionsGroup = new SharedParameterFile.Group("Dimensions", 101);
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("90850b08-3b50-4c46-95d6-24558d1f7800"), "Depth",
                dimensionsGroup, ParameterType.Length
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("00acc8ba-6168-415b-8570-0264a70a3053"), "Length",
                dimensionsGroup, ParameterType.Length
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("2ceb290a-55c6-40b4-a91b-0df3681f6520"), "Width",
                dimensionsGroup, ParameterType.Length
            ));

            #endregion

            #region Electrical

            var electricalGroup = new SharedParameterFile.Group("Electrical", 102);
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("5031db93-bb19-454e-bea4-0f77d60f15e6"), "ApparentPower",
                electricalGroup, ParameterType.ElectricalApparentPower
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("963abdb6-372f-496c-b99e-f11d8e0e5d20"), "Current",
                electricalGroup, ParameterType.ElectricalCurrent
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("c006d4d6-0b12-42ad-8078-fe38ab8b1eff"), "Phases",
                electricalGroup, ParameterType.NumberOfPoles
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("bce04092-fe19-476a-a652-4903bb02081e"), "Power",
                electricalGroup, ParameterType.ElectricalPower
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("ecebf138-86d6-4868-879c-bdc5a0b7d746"), "PowerFactor",
                electricalGroup, ParameterType.Number
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("ab0a5903-6625-482f-9e6b-f3bffb38dd13"), "Voltage",
                electricalGroup, ParameterType.ElectricalPotential
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("7dfc1be1-c5d2-471a-b341-7532d2d1627c"), "Wiring",
                electricalGroup, ParameterType.Text
            ));

            #endregion

            #region Plumbing

            var plumbingGroup = new SharedParameterFile.Group("Plumbing", 103);
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("99e06fdb-82cc-41fe-9fa2-9c524fec6f0f"), "Cold Water Size",
                plumbingGroup, ParameterType.PipeSize
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("a0030f64-4f46-4c02-a88e-a7e72a36611c"), "Cold Water Consumption",
                plumbingGroup, ParameterType.PipingFlow
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("b96ead64-4cb4-459e-aec0-787140811551"), "Cold Water Temperature",
                plumbingGroup, ParameterType.PipingTemperature
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("c031fafc-ce7b-423b-84a1-b87f48f89abf"), "Hot Water Size",
                plumbingGroup, ParameterType.PipeSize
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("6b2ae170-1a20-4bcc-a214-0fabb349dd8f"), "Hot Water Consumption",
                plumbingGroup, ParameterType.PipingFlow
            ));
            simpleSharedFromBuilt.Parameters.Add(new SharedParameterFile.Parameter(
                new Guid("66b5367d-78cd-477a-9fd3-0e04f8459d5a"), "Hot Water Supply Temperature",
                plumbingGroup, ParameterType.PipingTemperature
            ));

            #endregion

            var simpleSharedFromBuiltText = simpleSharedFromBuilt
                .ToString()
                .TrimEnd('\r', '\n', '\r')
                .Replace("\r\n", string.Empty)
                .Replace("\r", string.Empty)
                .Replace("\n", string.Empty);

            Assert.Equal(simpleSharedFromBuiltText, simpleSharedFromDisk);
        }
    }
}
