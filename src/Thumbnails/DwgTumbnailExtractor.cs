using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <summary>
    /// Utility class for DWG thumbnail creation
    /// This code is originally from http://www.theswamp.org:
    /// http://www.theswamp.org/index.php?topic=30985.msg470910#msg470910
    /// http://www.theswamp.org/index.php?topic=45598.msg507524#msg507524
    /// However some heavy changes have been applied
    /// </summary>
    public class DwgTumbnailExtractor : ThumbnailExtractor
    {
        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns>
        /// Memory stream containing thumbnail data
        /// </returns>
        /// <exception cref="InvalidDataException"></exception>
        public override MemoryStream ExtractStream(string pathToFile)
        {
            try
            {
                using var fileStream = new FileStream(pathToFile, FileMode.Open, FileAccess.Read, FileShare.Read);
                return ExtractStream(fileStream);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract the thumbnail of the following CAD drawing: {pathToFile}", ex);
            }
        }

        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="memoryStream">The memory stream.</param>
        /// <returns>
        /// Memory stream containing thumbnail data
        /// </returns>
        /// <exception cref="InvalidDataException">Failed to extract the thumbnail of the following CAD drawing</exception>
        /// <inheritdoc />
        public override MemoryStream ExtractStream(MemoryStream memoryStream)
        {
            try
            {
                return ExtractStream(memoryStream);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract the thumbnail of the following CAD drawing", ex);
            }
        }

        private MemoryStream ExtractStream(Stream fileStream)
        {
            using var binaryReader = new BinaryReader(fileStream);
            fileStream.Seek(0xd, SeekOrigin.Begin);
            fileStream.Seek(0x14 + binaryReader.ReadInt32(), SeekOrigin.Begin);

            var byteCount = binaryReader.ReadByte();
            if (byteCount <= 1)
            {
                return null;
            }

            for (short i = 1; i <= byteCount; i++)
            {
                var imageCode = binaryReader.ReadByte();
                var imageHeaderStart = binaryReader.ReadInt32();
                var imageHeaderSize = binaryReader.ReadInt32();
                var outms = new MemoryStream();

                switch (imageCode)
                {
                    case DwgFile.ThumbnailImageCodes.BMP:

                        #region BMP Preview (2010 file format and lower)

                        // BITMAPINFOHEADER (40 bytes)
                        binaryReader.ReadBytes(0xe);
                        var biBitCount = binaryReader.ReadUInt16();
                        binaryReader.ReadBytes(4);
                        var biSizeImage = binaryReader.ReadUInt32();
                        //-----------------------------------------------------
                        fileStream.Seek(imageHeaderStart, SeekOrigin.Begin);
                        var bitmapBuffer = binaryReader.ReadBytes(imageHeaderSize);
                        var colorTableSize = Convert.ToUInt32(Math.Truncate((biBitCount < 9) ? 4 * Math.Pow(2, biBitCount) : 0));
                        using (var ms = new MemoryStream())
                        {
                            using var binaryWriter = new BinaryWriter(ms);
                            binaryWriter.Write(Convert.ToUInt16(0x4d42));
                            binaryWriter.Write(54u + colorTableSize + biSizeImage);
                            binaryWriter.Write(new ushort());
                            binaryWriter.Write(new ushort());
                            binaryWriter.Write(54u + colorTableSize);
                            binaryWriter.Write(bitmapBuffer);

                            using var imageTmp = new Bitmap(ms);
                            imageTmp.Save(outms, ImageFormat.Png);
                            return outms;
                        }

                    #endregion

                    case DwgFile.ThumbnailImageCodes.PNG:

                        #region PNG Preview (2013 file format and higher)

                        fileStream.Seek(imageHeaderStart, SeekOrigin.Begin);
                        fileStream.CopyTo(outms, imageHeaderStart);
                        return outms;

                    #endregion

                    case DwgFile.ThumbnailImageCodes.NULL:
                        break; // DWG file doesn't contain a thumbnail
                }
            }

            return null;
        }

        internal struct DwgFile
        {
            internal struct ThumbnailImageCodes
            {
                public const byte BMP = 2;
                public const byte PNG = 6;
                public const byte NULL = 3;
            }
        }
    }
}
