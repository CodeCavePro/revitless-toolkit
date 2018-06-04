using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// ReSharper disable once CheckNamespace
namespace System.Text
{
    public static class FileInfoExtensions
    {
        public static readonly Regex UnicodeLetters;
        public static readonly Regex AnsiLatin1Mangled;

        /// <summary>
        /// Initializes the <see cref="FileInfoExtensions"/> class.
        /// </summary>
        static FileInfoExtensions()
        {
            AnsiLatin1Mangled = new Regex(@"[ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿŸ]", RegexOptions.Compiled | RegexOptions.Multiline);
            UnicodeLetters = new Regex(@"\p{L}", RegexOptions.Compiled | RegexOptions.Multiline);
        }

        /// <summary>
        /// Tries the get file encoding.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">file</exception>
        public static bool TryGetEncoding(this FileInfo file, out Encoding encoding)
        {
            if (null == file || !file.Exists)
                throw new ArgumentException($"{nameof(file)} must be a valid path to a file!");

            var bytes = new byte[10];
            using (var fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
            {
                fs.Read(bytes, 0, 10);
                fs.Close();
            }

            switch (bytes)
            {
                case var utf7 when 0x2B == utf7[0] && 0x2F == utf7[1] && 0x76 == utf7[2]:
                    encoding = Encoding.UTF7;
                    break;

                case var utf32 when 0 == utf32[0] && 0 == utf32[1] && 0xFE == utf32[2] && 0xFF == utf32[3]:
                    encoding = Encoding.UTF32;
                    break;

                case var unicode when 0xFE == unicode[0] && 0xFF == unicode[1]:
                    encoding = Encoding.GetEncoding(1201);  // 1201 unicodeFFFE Unicode (UTF-16BE)
                    break;

                case var unicode when 0xFF == unicode[0] && 0xFE == unicode[1]:
                    encoding = Encoding.GetEncoding(1200); // 1200 UTF-16 Unicode (UTF-16LE)
                    break;

                case var utf8 when HasBomMarker(utf8):
                    encoding = new UTF8Encoding(true); // UTF-8 with BOM
                    break;

                case var _ when file.IsInUtf8():
                    encoding = new UTF8Encoding(false); // UTF-8 without BOM
                    break;

                case var _ when file.IsInAnsiLatin1():
                    encoding = Encoding.GetEncoding(1252); // UTF-8 without BOM
                    break;

                default:
                    encoding = null;
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="throwIfNotDetected">if set to <c>true</c> [throws an exception if encoding is not detected].</param>
        /// <returns>
        /// Detected file encoding or null detection failed
        /// </returns>
        /// <exception cref="ArgumentException">file</exception>
        /// <exception cref="InvalidDataException"></exception>
        public static Encoding GetEncoding(this FileInfo file, bool throwIfNotDetected = false)
        {
            if (null == file || !file.Exists)
                throw new ArgumentException($"{nameof(file)} must be a valid path to a file!");

            var encoding = (file.TryGetEncoding(out var fileEncoding))
                ? fileEncoding
                : null;

            if (null == encoding && throwIfNotDetected)
            {
                throw new InvalidDataException(
                    $"Unable to detect encoding automatically of the following shared parameter file: {file.FullName}. " +
                    "Most likely it's a non-Latin ANSI, e.g. ANSI Cyrillic, Hebrew, Arabic, Greek, Turkish, Vietnamese etc"
                );
            }

            return encoding;
        }

        /// <summary>
        /// Determines whether [is in ANSI latin1] [the specified thresh hold].
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="mangledCharThreshold">The threshold of mangled characters.</param>
        /// <returns>
        ///   <c>true</c> if [file is ANSI Latin1-encoded] and [the number of mangled characters is lower than specified threshold]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">file</exception>
        public static bool IsInAnsiLatin1(this FileInfo file, double mangledCharThreshold = 60.0)
        {
            if (null == file || !file.Exists)
                throw new ArgumentException($"{nameof(file)} must be a valid path to a file!");

            var ansiLatin1Encoding = Encoding.GetEncoding(1252);
            var ansiText = File.ReadAllText(file.FullName, ansiLatin1Encoding);

            var unicodeLettersFound = UnicodeLetters.Matches(ansiText);
            var ansiMangledFound = AnsiLatin1Mangled.Matches(ansiText);
            var matchRate = ansiMangledFound.Count * 100 / unicodeLettersFound.Count;
            return (matchRate <= mangledCharThreshold);
        }

        /// <summary>
        /// Determines whether [has UTF-8 BOM marker].
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>
        ///   <c>true</c> if [the specified file] [has UTF-8 BOM marker]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">file</exception>
        public static bool HasBomMarker(this FileInfo file)
        {
            if (null == file || !file.Exists)
                throw new ArgumentException($"{nameof(file)} must be a valid path to a file!");

            var buffer = new byte[10];
            using (var fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
            {
                fs.Read(buffer, 0, 10);
                fs.Close();
            }

            return 0xEF == buffer[0] && 0xBB == buffer[1] && 0xBF == buffer[2];
        }

        /// <summary>
        /// Determines whether [has UTF-8 BOM  arker] [the specified bytes].
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>
        ///   <c>true</c> if [the specified bytes] [has UTF-8 BOM  marker]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">bytes</exception>
        public static bool HasBomMarker(byte[] bytes)
        {
            if (bytes == null || !bytes.Any())
                throw new ArgumentException($"{nameof(bytes)} must be a non-empty array of bytes!");

            return 0xEF == bytes[0] && 0xBB == bytes[1] && 0xBF == bytes[2];
        }

        /// <summary>
        /// Determines whether [is in UTF-8].
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>
        ///   <c>true</c> if[the specified file] [is in UTF-8]; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException">file</exception>
        public static bool IsInUtf8(this FileInfo file)
        {
            if (null == file || !file.Exists)
                throw new ArgumentException($"{nameof(file)} must be a valid path to a file!");

            try
            {
                using (var fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
                {
                    using (var streamReader = new StreamReader(fileStream, new UTF8Encoding(file.HasBomMarker(), true), true))
                    {
                        streamReader.ReadToEnd();
                    }
                }
                return true;
            }
            catch (DecoderFallbackException)
            {
                return false;
            }
        }
    }
}
