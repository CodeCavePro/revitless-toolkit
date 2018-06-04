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
            var groupLineRegex = new Regex(@"^GROUP(.+?)$", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase);

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
            var paramLineRegex = new Regex(@"^PARAM(.*)$", RegexOptions.Compiled | RegexOptions.Multiline | RegexOptions.IgnoreCase);

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
                    var paramGuids = paramLineMatches.Select(m => m.Groups["guid"].Value).Select(g => new Guid(g)).ToArray();
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
                    var groupNames = groupLineMatches.Select(m => m.Groups["name"].Value).Select(name => name.TrimEnd('\t', '\r')).ToArray();
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
        public void FilesAreEqual()
        {
            Assert.All(SharedParameterFiles,
                sharedParamFilePath =>
                {
                    var sharedParamFile1 = new SharedParameterFile(sharedParamFilePath);
                    var sharedParamFile2 = sharedParamFile1.CloneFile(true);
                    Assert.True(sharedParamFile1.Equals(sharedParamFile2));
                }
            );
        }
    }
}
