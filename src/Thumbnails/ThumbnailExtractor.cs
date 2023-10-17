using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <summary>
    /// Extracts thumbnails from 3D models without relying on proprietary APIs.
    /// </summary>
    public abstract class ThumbnailExtractor
    {
        private const string FileNameWildcard = "*.";

        private static readonly char[] ImageFormatSeparators = new[] { ';' };

        private static readonly Guid[] ValidThumbImageFormats = new[]
        {
            ImageFormat.Png.Guid,
            ImageFormat.Jpeg.Guid,
            ImageFormat.Bmp.Guid,
        };

        /// <summary>
        /// Extracts thumbnail to an image file.
        /// </summary>
        /// <param name="srcFile">The source file.</param>
        /// <param name="outFile">The output image file.</param>
        /// <returns>
        /// true if thumbnail has been extracted successfully.
        /// </returns>
        /// <exception cref="T:System.IO.InvalidDataException">Failed to extract to extract thumbnail from \"{srcFile}\" to \"{outFile}\.</exception>
        public virtual bool TryExtractFile(string srcFile, string outFile)
        {
            if (string.IsNullOrEmpty(srcFile) || !File.Exists(srcFile))
                throw new ArgumentException("Must be a valid path to an existing file", nameof(srcFile));

            if (string.IsNullOrEmpty(outFile) || outFile.Any(c => Path.GetInvalidPathChars().Contains(c)))
                throw new ArgumentException("Output file path is invalid", nameof(outFile));

            var imageBytes = ExtractThumbnailBytes(srcFile);

            try
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    using var imageTmp = Image.FromStream(ms);
                    var outFileReal = imageTmp.RawFormat switch
                    {
                        var validFormat when ValidThumbImageFormats.Contains(validFormat.Guid) => Path.ChangeExtension(outFile, $".{ImageFormatToExtension(validFormat)}"),
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

        /// <summary>
        /// Extracts thumbnail image to an array of bytes.
        /// </summary>
        /// <param name="stream">File stream.</param>
        /// <returns>
        /// Array of bytes containing thumbnail data.
        /// </returns>
        public abstract byte[] ExtractThumbnailBytes(Stream stream);

        /// <summary>
        /// Extracts thumbnail image to an array of bytes.
        /// </summary>
        /// <param name="bytes">Array of bytes to extract thumbnail from.</param>
        /// <returns>
        /// Array of bytes containing thumbnail data.
        /// </returns>
        public byte[] ExtractThumbnailBytes(byte[] bytes)
        {
            try
            {
                using var fileStream = new MemoryStream(bytes);
                return ExtractThumbnailBytes(fileStream);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to extract the thumbnail from an array of bytes.", ex);
            }
        }

        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="filePath">The path to file.</param>
        /// <returns>
        /// Array of bytes containing thumbnail data.
        /// </returns>
        public byte[] ExtractThumbnailBytes(string filePath)
        {
            try
            {
                var fileBytes = File.ReadAllBytes(filePath);
                return ExtractThumbnailBytes(fileBytes);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to extract the thumbnail from the following file: '{filePath}'", ex);
            }
        }

        /// <summary>
        /// Converts an image format to file extension.
        /// </summary>
        /// <param name="format">Image format.</param>
        /// <returns>File extension.</returns>
        private static string ImageFormatToExtension(ImageFormat format) =>
            ImageCodecInfo.GetImageEncoders()
                .FirstOrDefault(x => x.FormatID == format.Guid)?.FilenameExtension
                ?.Replace(FileNameWildcard, string.Empty)
                ?.ToLowerInvariant()
                ?.Split(ImageFormatSeparators, StringSplitOptions.RemoveEmptyEntries)
                ?.FirstOrDefault();
    }
}
