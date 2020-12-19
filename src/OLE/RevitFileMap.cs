using System.Text;

namespace CodeCave.Revit.Toolkit.OLE
{
    internal struct RevitFileMap
    {
        internal struct OleStreams
        {
            public const string IMAGE_STREAM = "RevitPreview4.0";
            public const string BASIC_FILE_INFO = "BasicFileInfo";
        }

        internal struct PngImageMarker
        {
            public const int MARKER_10 = 10;  // 0x0A
            public const int MARKER_13 = 13;  // 0x0D
            public const int MARKER_26 = 26;  // 0x1A
            public const int MARKER_71 = 71;  // 0x47
            public const int MARKER_78 = 78;  // 0x4E
            public const int MARKER_80 = 80;  // 0x50
            public const int MARKER_137 = 137; // 0x89
        }

        public static readonly Encoding[] SupportedEncodings = new[]
        {
            Encoding.UTF8,
            Encoding.Unicode,
            Encoding.BigEndianUnicode,
            Encoding.ASCII,
            Encoding.GetEncoding(1251),
            Encoding.UTF32,
            Encoding.GetEncoding(1252),
            Encoding.UTF7,
            Encoding.Default
        };
    }
}
