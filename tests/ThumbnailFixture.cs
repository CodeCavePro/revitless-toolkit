using System;
using System.IO;
using System.Linq;
using CodeCave.Revit.Toolkit.Thumbnails;
using Xunit;

namespace CodeCave.Revit.Toolkit.Tests
{
    public class ThumbnailFixture
    {
        private static readonly string PathToValidFiles, PathToInvalidFiles;

        /// <summary>
        /// Initializes the <see cref="TypeCatalogFileTests" /> class.
        /// </summary>
        static ThumbnailFixture()
        {
            var filesForThumbnails = Path.Combine(Environment.CurrentDirectory, "Resources", nameof(Thumbnails));
            PathToValidFiles = Path.Combine(filesForThumbnails, "Valid");
            PathToInvalidFiles = Path.Combine(filesForThumbnails, "Invalid");
        }

        [Theory]
        [InlineData("Thumbnails/Valid/qf_hatco_hdw-2bn_cat.rfa")]
        public void RfaThumbnailIsGenerated(string rfaRelativePath)
        {
            // setup
            rfaRelativePath = rfaRelativePath?.Replace('/', Path.DirectorySeparatorChar);
            var rfaFilePath = Directory.GetFiles(PathToValidFiles, "*.rfa").FirstOrDefault(f => f.EndsWith(rfaRelativePath));
            var rfaThumbnailPath = Path.ChangeExtension(Path.Combine(Environment.CurrentDirectory, Path.GetFileName(rfaFilePath)), "png");

            // act
            var rfaThumbnailer = new RfaTumbnailExtractor();
            var fileExtracted = rfaThumbnailer.TryExtractFile(rfaFilePath, rfaThumbnailPath);

            // assert
            Assert.True(fileExtracted);
            Assert.True(File.Exists(rfaThumbnailPath));
        }

        [Theory]
        [InlineData("Thumbnails/Valid/A1ANG-3.dwg")]
        public void DwgThumbnailIsGenerated(string dwgRelativePath)
        {
            // setup
            dwgRelativePath = dwgRelativePath?.Replace('/', Path.DirectorySeparatorChar);
            var dwgFilePath = Directory.GetFiles(PathToValidFiles, "*.dwg").FirstOrDefault(f => f.EndsWith(dwgRelativePath));
            var dwgThumbnailPath = Path.ChangeExtension(Path.Combine(Environment.CurrentDirectory, Path.GetFileName(dwgFilePath)), "png");

            // act
            var dwgThumbnailer = new DwgTumbnailExtractor();
            var fileExtracted = dwgThumbnailer.TryExtractFile(dwgFilePath, dwgThumbnailPath);

            // assert
            Assert.True(fileExtracted);
            Assert.True(File.Exists(dwgThumbnailPath));
        }
    }
}
