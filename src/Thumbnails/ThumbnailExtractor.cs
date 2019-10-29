using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <inheritdoc />
    /// <summary>
    /// Extracts thumbnails from 3D models without relying on proprietary APIs
    /// </summary>
    /// <seealso cref="T:CodeCave.CAD.Toolkit.Primitives.IThumbnailExtractor" />
    public abstract class ThumbnailExtractor : IThumbnailExtractor
    {
        private static readonly Guid[] validThumbImageFormats;

        /// <summary>
        /// Initializes the <see cref="ThumbnailExtractor"/> class.
        /// </summary>
        static ThumbnailExtractor()
        {
            validThumbImageFormats = new[] { ImageFormat.Png.Guid, ImageFormat.Jpeg.Guid, ImageFormat.Bmp.Guid };
        }

        /// <inheritdoc />
        /// <summary>
        /// Extracts thumbnail to an image file.
        /// </summary>
        /// <param name="srcFile">The source file.</param>
        /// <param name="outFile">The output image file.</param>
        /// <returns>
        /// true if thumbnail has been extracted successfully
        /// </returns>
        /// <exception cref="T:System.IO.InvalidDataException">Failed to extract to extract thumbnail from \"{srcFile}\" to \"{outFile}\</exception>
        public virtual bool TryExtractFile(string srcFile, string outFile)
        {
            if (string.IsNullOrEmpty(srcFile) || !File.Exists(srcFile))
                throw new ArgumentException("Must be a valid path to an existing file", nameof(srcFile));

            if (string.IsNullOrEmpty(outFile) || outFile.Any(c => Path.GetInvalidPathChars().Contains(c)))
                throw new ArgumentException("Output file path is invalid", nameof(outFile));

            var imageBytes = ExtractImageBytes(srcFile);

            try
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    using var imageTmp = Image.FromStream(ms);
                    var outFileReal = imageTmp.RawFormat switch
                    {
                        var validFormat when validThumbImageFormats.Contains(validFormat.Guid) => Path.ChangeExtension(outFile, $".{ImageFormatToExtension(validFormat)}"),

                        _ => throw new InvalidOperationException($"Thumbnail has an invalid format - {imageTmp.RawFormat}"),
                    };

                    if (!Path.GetExtension(outFile).Equals(Path.GetExtension(outFileReal), StringComparison.OrdinalIgnoreCase))
                        throw new ArgumentException($"Output file path doesn't match thumbnail's format ({Path.GetExtension(outFileReal)})", nameof(outFile));

                    imageTmp.Save(outFile);
                }

                return File.Exists(outFile);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract to extract thumbnail from \"{srcFile}\" to \"{outFile}\"", ex);
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Extracts thumbnail to an image object.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns></returns>
        public virtual byte[] ExtractImageBytes(string pathToFile)
        {
            using var imageStream = ExtractStream(pathToFile);
            return ImageStreamToBytes(imageStream);
        }

        /// <summary>
        /// Extracts thumbnail to an image object.
        /// </summary>
        /// <param name="memoryStream">The memory stream.</param>
        /// <returns></returns>
        public virtual byte[] ExtractImageBytes(MemoryStream memoryStream)
        {
            using var imageStream = ExtractStream(memoryStream);
            return ImageStreamToBytes(imageStream);
        }

        /// <inheritdoc />
        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns>
        /// Memory stream containing thumbnail data
        /// </returns>
        public abstract MemoryStream ExtractStream(string pathToFile);

        /// <inheritdoc />
        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="memoryStream">The memory stream.</param>
        /// <returns>
        /// Memory stream containing thumbnail data
        /// </returns>
        public abstract MemoryStream ExtractStream(MemoryStream memoryStream);

        #region Helpers

        /// <summary>
        /// Converts an image format to file extension.
        /// </summary>
        /// <param name="format">Image format.</param>
        /// <returns>File extension</returns>
        private static string ImageFormatToExtension(ImageFormat format)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(x => x.FormatID == format.Guid)
                ?.FilenameExtension.Replace("*.", "")?.ToLowerInvariant()?.Split(';')?.FirstOrDefault();
        }

        /// <summary>
        /// Converts a memory stream containing image to bytes.
        /// </summary>
        /// <param name="imageStream">The image stream.</param>
        /// <returns></returns>
        private byte[] ImageStreamToBytes(MemoryStream imageStream)
        {
            var imageBytes = imageStream?.ToArray();
            if ((imageBytes?.Length ?? 0) <= 0)
                throw new InvalidDataException("Thumbnail as array of bytes cannot be empty");

            return imageBytes;
        }

        #endregion Helpers
    }
}
