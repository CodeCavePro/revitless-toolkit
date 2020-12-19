using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CodeCave.Revit.Toolkit.OLE;
using CodeCave.Revit.Toolkit.Parameters;
using CodeCave.Revit.Toolkit.Parameters.Catalog;
using Xunit;

namespace CodeCave.Revit.Toolkit.Tests
{
    public class TypeCatalogFileTests
    {
        private static readonly string[] CatalogTypeFiles;
        private static readonly string PathToValidFiles, PathToInvalidFiles;

        /// <summary>
        /// Initializes the <see cref="TypeCatalogFileTests" /> class.
        /// </summary>
        static TypeCatalogFileTests()
        {
            var sharedParamFilesDir = Path.Combine(Environment.CurrentDirectory, "Resources", nameof(TypeCatalogFile));
            PathToValidFiles = Path.Combine(sharedParamFilesDir, "Valid");
            PathToInvalidFiles = Path.Combine(sharedParamFilesDir, "Invalid");
            CatalogTypeFiles = Directory.GetFiles(sharedParamFilesDir, "*.txt", SearchOption.AllDirectories);
        }

        /// <summary>
        /// Checks if the count of parameters is correct.
        /// </summary>
        [Fact]
        public void CheckIfNumberOfParametersIsCorrect()
        {
            Assert.All(CatalogTypeFiles.Where(f => f.StartsWith(PathToValidFiles, StringComparison.InvariantCulture)),
                catalogTypeFilePath =>
                {
                    var catalogTypeFile = new TypeCatalogFile(catalogTypeFilePath);
                    var catalogTypeFileText = File.ReadAllLines(catalogTypeFilePath);
                    var catalogTypeFileHeader = catalogTypeFileText.FirstOrDefault();
                    Assert.Equal(catalogTypeFile.parameterDefinitions.Count, catalogTypeFileHeader?.Count(f => f == ',') ?? 0);
                }
            );
        }

        /// <summary>
        /// Checks if the number of types is correct.
        /// </summary>
        [Fact]
        public void CheckIfNumberOfTypesIsCorrect()
        {
            Assert.All(CatalogTypeFiles.Where(f => f.StartsWith(PathToValidFiles, StringComparison.InvariantCulture)),
                catalogTypeFilePath =>
                {
                    var catalogTypeFile = new TypeCatalogFile(catalogTypeFilePath);
                    var catalogTypeFileText = File.ReadAllLines(catalogTypeFilePath);
                    Assert.Equal(catalogTypeFile.Types.Count, catalogTypeFileText?.Count(l => !string.IsNullOrWhiteSpace(l)) - 1);
                }
            );
        }

        /// <summary>
        /// Builds a catalog of iPhone products and compares it to the same catalog stored on disk.
        /// </summary>
        [Fact]
        public void AppleCatalogReadAndBuiltAreEqual()
        {
            var catalogTypeFile = AppleTypeCatalogInstance();
            var catalogTypeFileFromBuilt = catalogTypeFile.ToString();
            Assert.True(!string.IsNullOrWhiteSpace(catalogTypeFileFromBuilt));

            var iPhoneCatalogFilePath = CatalogTypeFiles.FirstOrDefault(f => f.EndsWith(@"iPhone6.txt", StringComparison.InvariantCulture));
            var iPhoneCatalogFromDisk = File.ReadAllText(iPhoneCatalogFilePath);
            Assert.True(File.Exists(iPhoneCatalogFilePath) && !string.IsNullOrWhiteSpace(iPhoneCatalogFromDisk));

            // Remove any difference in terms of line endings
            var simpleSharedFromBuiltText = catalogTypeFileFromBuilt
                .Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\n")
                .TrimEnd('\n');

            iPhoneCatalogFromDisk = iPhoneCatalogFromDisk
                .Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\n")
                .TrimEnd('\n');

            Assert.Equal(simpleSharedFromBuiltText, iPhoneCatalogFromDisk);
        }

        /// <summary>
        /// Saves the a catalog to a file.
        /// </summary>
        [Fact]
        public void SavingTypeCatalogToFile()
        {
            var catalogTypeFile = AppleTypeCatalogInstance();
            var catalogTypeFileTmp = $"{Path.GetTempFileName()}.txt";;
            Assert.True(catalogTypeFile.Save(catalogTypeFileTmp) && File.Exists(catalogTypeFileTmp));
        }

        /// <summary>
        /// is the phone type catalog instance.
        /// </summary>
        /// <returns></returns>
        private static TypeCatalogFile AppleTypeCatalogInstance()
        {
            var catalogTypeFile = new TypeCatalogFile();
            var commonParams = new List<IParameterWithValue>
            {
                new TypeCatalogFile.Parameter<string>("Manufacturer", ParameterType.Text, "Apple"),
                new TypeCatalogFile.Parameter<string>("Model", ParameterType.Text, "A1549"),
                new TypeCatalogFile.Parameter<double>("Width", ParameterType.Length, 77.8, DisplayUnitType.DUT_MILLIMETERS),
                new TypeCatalogFile.Parameter<double>("Depth", ParameterType.Length, 6.9, DisplayUnitType.DUT_MILLIMETERS),
                new TypeCatalogFile.Parameter<double>("Height", ParameterType.Length, 158.1, DisplayUnitType.DUT_MILLIMETERS),
            };

            catalogTypeFile.Add("MG562LL/A", commonParams.Concat(new List<IParameterWithValue>
            {
                new TypeCatalogFile.Parameter<string>("AssemblyCode", ParameterType.Text, "MG562LL/A"),
                new TypeCatalogFile.Parameter<string>("Description", ParameterType.Text, "iPhone 6 16GB Gold (GSM) T-Mobile"),
                new TypeCatalogFile.Parameter<double>("Price", ParameterType.Currency, 299.90),
                new TypeCatalogFile.Parameter<string>("Currency", ParameterType.Text, "$"),
                new TypeCatalogFile.Parameter<int>("Storage GB", 16),
                new TypeCatalogFile.Parameter<bool>("Unlocked", ParameterType.YesNo, false),
            }).ToArray());
            catalogTypeFile.Add("MG5D2LL/A", commonParams.Concat(new List<IParameterWithValue>
            {
                new TypeCatalogFile.Parameter<string>("AssemblyCode", ParameterType.Text, "MG5D2LL/A"),
                new TypeCatalogFile.Parameter<string>("Description", ParameterType.Text, "iPhone 6 64GB Gold (GSM) T-Mobile"),
                new TypeCatalogFile.Parameter<double>("Price", ParameterType.Currency, 380.0),
                new TypeCatalogFile.Parameter<string>("Currency", ParameterType.Text, "$"),
                new TypeCatalogFile.Parameter<int>("Storage GB", 32),
                new TypeCatalogFile.Parameter<bool>("Unlocked", ParameterType.YesNo, false),
            }).ToArray());
            catalogTypeFile.Add("MG3A2CL/A", commonParams.Concat(new List<IParameterWithValue>
            {
                new TypeCatalogFile.Parameter<string>("AssemblyCode", ParameterType.Text, "MG3A2CL/A"),
                new TypeCatalogFile.Parameter<string>("Description", ParameterType.Text, "iPhone 6 16GB Space Grey Unlocked"),
                new TypeCatalogFile.Parameter<double>("Price", ParameterType.Currency, 600.0),
                new TypeCatalogFile.Parameter<string>("Currency", ParameterType.Text, "CAD"),
                new TypeCatalogFile.Parameter<int>("Storage GB", 16),
                new TypeCatalogFile.Parameter<bool>("Unlocked", ParameterType.YesNo, true),
            }).ToArray());

            return catalogTypeFile;
        }
    }
}
