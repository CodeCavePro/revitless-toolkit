using System;
using System.IO;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <summary>
    /// Extracts thumbnails from 3D models without relying on proprietary APIs.
    /// </summary>
    public abstract class ThumbnailExtractor
    {
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
    }
}
