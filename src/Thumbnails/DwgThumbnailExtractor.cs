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
        private static readonly Color ColorBlack = Color.Black;

        private static readonly Color ColorWhite = Color.White;

        private bool RetainBackgroudColor { get; set; } = true;

        /// <inheritdoc/>
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
                var thumbInfo = new ThumbnailInfo
                {
                    Type = binaryReader.ReadByte(),
                    Start = binaryReader.ReadInt32(),
                    Length = binaryReader.ReadInt32(),
                };

#pragma warning disable CC0120 // default just skips to the next byte
                switch (thumbInfo.Type)
                {
                    // PNG thumbnail - ACAD 2013 and later
                    case ThumbnailInfo.PngType:
                        var ms2013 = new MemoryStream();
                        stream.Seek(thumbInfo.Start, SeekOrigin.Begin);
                        stream.CopyTo(ms2013, thumbInfo.Length);
                        var byte2013 = ms2013.ToArray();

                        return byte2013;

                    // BMP Preview (2010 file format and lower)
                    case ThumbnailInfo.BmpType:

                        for (var intCnt = 0; intCnt < byteCount; intCnt++)
                        {
                            stream.Seek(thumbInfo.Start, SeekOrigin.Begin);
                            var udtHeader = new BitmapHeader
                            {
                                Size = binaryReader.ReadInt32(),
                                Width = binaryReader.ReadInt32(),
                                Height = binaryReader.ReadInt32(),
                                Planes = binaryReader.ReadInt16(),
                                BitCount = binaryReader.ReadInt16(),
                                Compression = binaryReader.ReadInt32(),
                                SizeImage = binaryReader.ReadInt32(),
                                XPelsPerMeter = binaryReader.ReadInt32(),
                                YPelsPerMeter = binaryReader.ReadInt32(),
                                ClrUsed = binaryReader.ReadInt32(),
                                ClrImportant = binaryReader.ReadInt32(),
                            };

                            var bytBMPBuff = new byte[thumbInfo.Length + 1];

                            if (udtHeader.BitCount != 8)
                            {
                                continue;
                            }

                            var udtColors = new RgbQuad[256];
                            for (int count = 0; count < 256; count++)
                            {
                                udtColors[count].Blue = binaryReader.ReadByte();
                                udtColors[count].Green = binaryReader.ReadByte();
                                udtColors[count].Red = binaryReader.ReadByte();
                                udtColors[count].Reserved = binaryReader.ReadByte();
                            }
                            stream.Seek(thumbInfo.Start - 1, SeekOrigin.Begin);

                            for (int count = 0; count <= thumbInfo.Length; count++)
                                bytBMPBuff[count] = binaryReader.ReadByte();

                           var bmp = new Bitmap(udtHeader.Width, udtHeader.Height);
                            var lngCnt = 0;

                            for (var lngY = 1; lngY <= udtHeader.Height; lngY++)
                            {
                                for (var lngX = udtHeader.Width; lngX >= 1; lngX--)
                                {
                                    int lngColor = bytBMPBuff[bytBMPBuff.GetUpperBound(0) - lngCnt];
                                    var udtColor = udtColors[lngColor];

                                    var intRed = Convert.ToInt16(udtColor.Red);
                                    var intGreen = Convert.ToInt16(udtColor.Green);
                                    var intBlue = Convert.ToInt16(udtColor.Blue);
                                    lngColor = ColorTranslator.ToOle(Color.FromArgb(intRed, intGreen, intBlue));

                                    if (!RetainBackgroudColor)
                                    {
                                        if (lngColor == ColorTranslator.ToOle(ColorBlack))
                                            lngColor = ColorTranslator.ToOle(ColorWhite);
                                        else if (lngColor == ColorTranslator.ToOle(ColorWhite))
                                            lngColor = ColorTranslator.ToOle(ColorBlack);
                                    }

                                    bmp.SetPixel(lngX - 1, lngY - 1, ColorTranslator.FromOle(lngColor));
                                    lngCnt++;
                                }
                            }

                            using var outputStream = new MemoryStream();
                            bmp.Save(outputStream, ImageFormat.Png);
                            return outputStream.ToArray();
                        }

                        return new byte[0];

                    case ThumbnailInfo.NullType:
                        break; // DWG file doesn't contain a thumbnail
                }
#pragma warning restore CC0120
            }

            return new byte[0];
        }

        private struct ThumbnailInfo
        {
            public const byte BmpType = 2;
            public const byte PngType = 6;
            public const byte NullType = 3;

            public byte Type;
            public int Start;
            public int Length;
        }

        private struct BitmapHeader
        {
            public int Size;
            public int Width;
            public int Height;
            public short Planes;
            public short BitCount;
            public int Compression;
            public int SizeImage;
            public int XPelsPerMeter;
            public int YPelsPerMeter;
            public int ClrUsed;
            public int ClrImportant;
        }

        private struct RgbQuad
        {
            public byte Blue;
            public byte Green;
            public byte Red;
            public byte Reserved;
        }
    }
}
