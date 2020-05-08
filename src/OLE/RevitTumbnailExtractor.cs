using System;
using System.IO;
using CodeCave.Revit.Toolkit.OLE;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <summary>
    /// Utility class for Revit (.rfa, .rvt etc) thumbnail creation
    /// Inspired by Jeremy Tammik's post on The Building Coder website
    /// http://thebuildingcoder.typepad.com/blog/2008/10/rvt-file-version.html
    /// </summary>
    /// <seealso cref="ThumbnailExtractor" />
    public partial class RevitTumbnailExtractor : ThumbnailExtractor
    {
        #region Methods

        /// <summary>
        /// Extracts the stream.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException"></exception>
        private MemoryStream ExtractStream(byte[] thumbnailBytes)
        {
            try
            {
                // Validate preview data or go out
                if ((thumbnailBytes == null) || (thumbnailBytes.Length <= 0))
                {
                    return null;
                }

                // read past the Revit meta-data to the start of the PNG image
                var startingOffset = GetPngOffset(thumbnailBytes);
                if (startingOffset == 0)
                {
                    return null;
                }

                var previewUpperBound = thumbnailBytes.GetUpperBound(0);
                var pngDataBuffer = new byte[previewUpperBound - startingOffset + 1];

                using (var ms = new MemoryStream(thumbnailBytes))
                {
                    ms.Position = startingOffset;
                    ms.Read(pngDataBuffer, 0, pngDataBuffer.Length);

                    // read the PNG image data into a byte array
                    var outms = new MemoryStream(pngDataBuffer);
                    return outms;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract the thumbnail of the Revit file", ex);
            }
        }

        public override MemoryStream ExtractStream(string pathToFile)
        {
            try
            {
                var thumbnailBytes = OleDataReader.GetRawBytes(pathToFile, RevitFileMap.OleStreams.IMAGE_STREAM);
                return ExtractStream(thumbnailBytes);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract the thumbnail of the following Revit file \"{pathToFile}\"", ex);
            }
        }

        public override MemoryStream ExtractStream(MemoryStream memoryStream)
        {
            try
            {
                var thumbnailBytes = OleDataReader.GetRawBytes(memoryStream, RevitFileMap.OleStreams.IMAGE_STREAM);
                return ExtractStream(thumbnailBytes);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract the thumbnail of the Revit file", ex);
            }
        }

        #endregion Methods

        #region Helpers

        /// <summary>
        /// Gets the PNG data offset in array of bytes.
        /// </summary>
        /// <param name="thumbnailBytes">Thumbnail bytes.</param>
        /// <returns></returns>
        private static int GetPngOffset(byte[] thumbnailBytes)
        {
            var markerFound = false;
            var startingOffset = 0;
            var previousValue = 0;

            using (var memoryStream = new MemoryStream(thumbnailBytes))
            {
                for (var i = 0; i < thumbnailBytes.Length; i++)
                {
                    var pointer = memoryStream.ReadByte();
                    // possible start of PNG file data
                    if (pointer == RevitFileMap.PngImageMarker.MARKER_137) // 0x89
                    {
                        markerFound = true;
                        startingOffset = i;
                        previousValue = pointer;
                        continue;
                    }

                    switch (pointer)
                    {
                        case RevitFileMap.PngImageMarker.MARKER_10: // 0x0A
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_26))
                            {
                                return startingOffset;
                            }
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_13))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFileMap.PngImageMarker.MARKER_13: // 0x0D
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_71))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFileMap.PngImageMarker.MARKER_26: // 0x1A
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_10))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFileMap.PngImageMarker.MARKER_71: // 0x47
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_78))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFileMap.PngImageMarker.MARKER_78: // 0x4E
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_80))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFileMap.PngImageMarker.MARKER_80: // 0x50
                            if (markerFound && (previousValue == RevitFileMap.PngImageMarker.MARKER_137))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;
                    }
                }
            }
            return 0;
        }

        #endregion Helpers
    }
}
