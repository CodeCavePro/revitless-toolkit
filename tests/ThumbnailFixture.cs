#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable S3963 // "static" fields should be initialized inline

using System;
using System.IO;
using System.Linq;
using CodeCave.Revit.Toolkit.Thumbnails;
using Xunit;

namespace CodeCave.Revit.Toolkit.Tests
{
    public class ThumbnailFixture
    {
        private static readonly string PathToValidFiles;

        /// <summary>
        /// Initializes static members of the <see cref="ThumbnailFixture"/> class.
        /// </summary>
        static ThumbnailFixture()
        {
            var filesForThumbnails = Path.Combine(Environment.CurrentDirectory, "Resources", nameof(Thumbnails));
            PathToValidFiles = Path.Combine(filesForThumbnails, "Valid");
        }

        /// <summary>The thumbnails are generated for DWGs.</summary>
        /// <param name="dwgRelativePath">The DWG relative path.</param>
        [Theory]
        [InlineData("Thumbnails/Valid/A1ANG-3.dwg")]
        [InlineData("Thumbnails/Valid/7-PS-66_R3.dwg")]
        [InlineData("Thumbnails/Valid/U0000850_7-PS-66.DWG")]
        public void DwgThumbnailIsGenerated(string dwgRelativePath)
        {
            // Setup
            dwgRelativePath = dwgRelativePath?.Replace('/', Path.DirectorySeparatorChar);
            var dwgFilePath = Directory.GetFiles(PathToValidFiles, "*.dwg").FirstOrDefault(f => f.EndsWith(dwgRelativePath));
            var dwgThumbnailPath = Path.ChangeExtension(Path.Combine(Environment.CurrentDirectory, Path.GetFileName(dwgFilePath)), "png");

            // Act
            var dwgThumbnailer = new DwgThumbnailExtractor();
            var fileExtracted = dwgThumbnailer.TryExtractFile(dwgFilePath, dwgThumbnailPath);

            // Assert
            Assert.True(fileExtracted);
            Assert.True(File.Exists(dwgThumbnailPath));
        }

        /// <summary>The thumbnails are generated for RFAs.</summary>
        /// <param name="rfaRelativePath">The rfa relative path.</param>
        [Theory]
        [InlineData("Thumbnails/Valid/qf_hatco_hdw-2bn_cat.rfa")]
        public void RfaThumbnailIsGenerated(string rfaRelativePath)
        {
            // Setup
            rfaRelativePath = rfaRelativePath?.Replace('/', Path.DirectorySeparatorChar);
            var rfaFilePath = Directory.GetFiles(PathToValidFiles, "*.rfa").FirstOrDefault(f => f.EndsWith(rfaRelativePath));
            var rfaThumbnailPath = Path.ChangeExtension(Path.Combine(Environment.CurrentDirectory, Path.GetFileName(rfaFilePath)), "png");

            // Act
            var rfaThumbnailer = new RevitTumbnailExtractor();
            var fileExtracted = rfaThumbnailer.TryExtractFile(rfaFilePath, rfaThumbnailPath);

            // Assert
            Assert.True(fileExtracted);
            Assert.True(File.Exists(rfaThumbnailPath));
        }
    }
}
