using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <summary>
    /// Utility class for DWG thumbnail creation.
    /// </summary>
    public class DwgThumbnailExtractor : ThumbnailExtractor
    {
        public override byte[] ExtractThumbnailBytes(Stream stream)
        {
            using var binaryReader = new BinaryReader(stream);
            stream.Seek(0xd, SeekOrigin.Begin);
            stream.Seek(0x14 + binaryReader.ReadInt32(), SeekOrigin.Begin);

            var byteCount = binaryReader.ReadByte();
            if (byteCount <= 1)
            {
                return new byte[0];
            }

            for (short i = 1; i <= byteCount; i++)
            {
                var imageCode = binaryReader.ReadByte();
                var imageHeaderStart = binaryReader.ReadInt32();
                var imageHeaderSize = binaryReader.ReadInt32();

#pragma warning disable CC0120 // default just skips to the next byte
                switch (imageCode)
                {
                    // PNG thumbnail - ACAD 2013 and later
                    case ThumbnailImageCodes.PNG:
                        var ms2013 = new MemoryStream();
                        stream.Seek(imageHeaderStart, SeekOrigin.Begin);
                        stream.CopyTo(ms2013, imageHeaderSize);
                        var byte2013 = ms2013.ToArray();

                        return byte2013;

                    // BMP Preview (2010 file format and lower)
                    case ThumbnailImageCodes.BMP:
                        binaryReader.ReadBytes(0xe);
                        var biBitCount = binaryReader.ReadUInt16();
                        binaryReader.ReadBytes(4);
                        var biSizeImage = binaryReader.ReadUInt32();

                        stream.Seek(imageHeaderStart, SeekOrigin.Begin);
                        var bitmapBuffer = binaryReader.ReadBytes(imageHeaderSize);
                        var bitCountRaw = (biBitCount < 9) ? 4 * Math.Pow(2, biBitCount) : 0;
                        var bitCount = Math.Truncate(bitCountRaw);
                        var colorTableSize = Convert.ToUInt32(bitCount);
                        using (var ms = new MemoryStream())
                        {
                            using var binaryWriter = new BinaryWriter(ms);
                            binaryWriter.Write(Convert.ToUInt16(0x4d42));
                            binaryWriter.Write(54u + colorTableSize + biSizeImage);
                            binaryWriter.Write(default(ushort));
                            binaryWriter.Write(default(ushort));
                            binaryWriter.Write(54u + colorTableSize);
                            binaryWriter.Write(bitmapBuffer);

                            using var imageTmp2010 = new Bitmap(ms);
                            var bytes2010 = ToByteArray(imageTmp2010, ImageFormat.Png);

                            return bytes2010;
                        }

                    case ThumbnailImageCodes.NULL:
                        break; // DWG file doesn't contain a thumbnail
                }
#pragma warning restore CC0120
            }

            return new byte[0];
        }

        public static byte[] ToByteArray(Image image, ImageFormat format)
        {
            using var ms = new MemoryStream();
            image.Save(ms, format);
            return ms.ToArray();
        }

        private struct ThumbnailImageCodes
        {
            internal const byte BMP = 2;
            internal const byte PNG = 6;
            internal const byte NULL = 3;
        }
    }
}
