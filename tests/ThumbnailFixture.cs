#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable S3963 // "static" fields should be initialized inline

using System;
using System.Drawing;
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
            var dwgThumbnailPath = Path.ChangeExtension(dwgFilePath, "png");

            // Act
            var dwgThumbnailer = new DwgThumbnailExtractor();
            var thumbDwgBytes = dwgThumbnailer.ExtractThumbnailBytes(dwgFilePath);
            var thumbPngBytes = File.ReadAllBytes(dwgThumbnailPath);

            // Assert
            Assert.NotEmpty(thumbDwgBytes);

            // The DWG thumbnail is re-encoded to PNG by the extractor, and PNG encoders produce
            // slightly different (but equally valid) byte streams across .NET Framework / .NET 8,
            // so compare decoded pixels instead of raw bytes
            AssertImagePixelsEqual(thumbPngBytes, thumbDwgBytes);
        }

        /// <summary>Asserts that two PNG byte arrays decode to images with identical dimensions and pixels.</summary>
        /// <param name="expectedImageBytes">The expected image bytes.</param>
        /// <param name="actualImageBytes">The actual image bytes.</param>
        private static void AssertImagePixelsEqual(byte[] expectedImageBytes, byte[] actualImageBytes)
        {
            using var expectedStream = new MemoryStream(expectedImageBytes);
            using var actualStream = new MemoryStream(actualImageBytes);
            using var expected = new Bitmap(expectedStream);
            using var actual = new Bitmap(actualStream);

            Assert.Equal(expected.Size, actual.Size);

            for (var y = 0; y < expected.Height; y++)
            {
                for (var x = 0; x < expected.Width; x++)
                {
                    if (expected.GetPixel(x, y) != actual.GetPixel(x, y))
                    {
                        Assert.True(false, $"Decoded thumbnail differs from the reference image at pixel ({x}, {y})");
                    }
                }
            }
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
            var rfaThumbnailPath = Path.ChangeExtension(rfaFilePath, "png");

            // Act
            var rfaThumbnailer = new RevitTumbnailExtractor();
            var thumbRfaBytes = rfaThumbnailer.ExtractThumbnailBytes(rfaFilePath);
            var thumbPngBytes = File.ReadAllBytes(rfaThumbnailPath);

            // Assert
            Assert.NotEmpty(thumbRfaBytes);
            Assert.Equal(thumbPngBytes, thumbRfaBytes);
        }
    }
}
