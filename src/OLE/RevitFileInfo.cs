using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static CodeCave.Revit.Toolkit.RevitFileInfoExtensions;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class RevitFileInfo
    {
        private static readonly Regex asianCharMatcher = new Regex(@"\p{IsCJKUnifiedIdeographs}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        static RevitFileInfo()
        {
#if !NET45
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif
        }

        #region Properties

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; internal set; }

        /// <summary>
        /// Gets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        public Guid Guid { get; internal set; }

        /// <summary>
        /// Gets the locale.
        /// </summary>
        /// <value>
        /// The locale.
        /// </value>
        public CultureInfo Locale { get; internal set; }

        /// <summary>
        /// Gets or sets the part atom.
        /// </summary>
        /// <value>
        /// The part atom.
        /// </value>
        public PartAtom PartAtom { get; private set; }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string Category => PartAtom?.Category;

        /// <summary>
        /// Gets the types.
        /// </summary>
        /// <value>
        /// The types.
        /// </value>
        public FamilyType[] Types => PartAtom?.Family?.Parts;

        public string ProductVendor { get; internal set; } = "Autodesk";

        public string ProductVersion { get; internal set; }

        public string ProductName { get; internal set; } = "Revit";

        public int Format { get; internal set; }

        public bool Is64Bit { get; internal set; } = true;

        public string FilePath { get; private set; }

        #endregion

        #region Methods

        public static int GetFormatFromFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                throw new ArgumentException("Please supply a valid path to a Revit document", nameof(filePath));

            try
            {
                var basicInfo = OleDataReader.GetRawBytes(filePath, RevitFileMap.OleStreams.BASIC_FILE_INFO);
                var properties = GetProperties(basicInfo);
                var formatFromBasicInfo = properties.GetFormat();
                if (formatFromBasicInfo > 0)
                    return formatFromBasicInfo;
            }
            catch
            {
                // TODO ad logging
                // Trying to read
            }

            try
            {
                var partAtom = PartAtom.GetFromFile(filePath);
                var formatFromPartAtom = partAtom?.Link?.Files?.FirstOrDefault()?.ProductVersion;
                if (formatFromPartAtom != null)
                    return formatFromPartAtom.GetValueOrDefault();
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Couldn't read format information from the followin file: '{filePath}'", ex);
            }

            return -1;
        }

        /// <summary>
        /// Gets a <see cref="RevitFileInfo" /> instance from the given file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="readProperties">if set to <c>true</c> [read properties].</param>
        /// <param name="readTypes">if set to <c>true</c> [read types].</param>
        /// <returns></returns>
        /// <exception cref="T:System.ArgumentException">filePath is invalid.</exception>
        public static RevitFileInfo GetFromFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
                throw new ArgumentException("Please supply a valid path to a Revit document", nameof(filePath));

            var rfi = new RevitFileInfo
            {
                FilePath = filePath
            };

            // Read basic file info from metadata
            try
            {
                var basicInfo = OleDataReader.GetRawBytes(filePath, RevitFileMap.OleStreams.BASIC_FILE_INFO);
                var properties = GetProperties(basicInfo);
                rfi.ParseDocumentInfo(properties);
                rfi.ParseLocale(properties);
                rfi.ParseRevit(properties);
                rfi.ParseUsername(properties);
            }
            catch (Exception)
            {
                // TODO log the error
            }

            // Read family types from part atom
            try
            {
                rfi.PartAtom = PartAtom.GetFromFile(filePath);
                if (rfi.Format <= 0)
                    rfi.Format = rfi.PartAtom?.Link?.Files?.FirstOrDefault()?.ProductVersion ?? -1;
            }
            catch (Exception)
            {
                // TODO log the error
            }

            return rfi;
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        internal static Dictionary<string, string> GetProperties(byte[] basicInfo)
        {
            var fileProps = new Dictionary<string, string>();
            const char marker = '\u0a0d';

            foreach (var encoding in RevitFileMap.SupportedEncodings)
            {
                var basicInfoString = encoding.GetString(basicInfo);
                if (!basicInfoString.Contains(marker))
                    continue;

                basicInfo = basicInfo.Skip(SearchBytes(basicInfo, encoding.GetBytes(new[] { marker }))).ToArray();
                basicInfoString = encoding.GetString(basicInfo).Trim(marker);

                using var basicInfoReader = new StringReader(basicInfoString?.Replace("\0", string.Empty));
                string stringLine;
                while ((stringLine = basicInfoReader.ReadLine()) != null)
                {
                    var parts = stringLine.Split(new[] { ":" }, 2, StringSplitOptions.None);
                    fileProps.Add(parts[0].Trim(), parts[1].Trim());
                }
            }

            return fileProps;
        }

        private static bool IsInvalidProperty(string input)
        {
            return input?.Any(c => char.IsControl(c)) ?? true;
        }

        private static int SearchBytes(byte[] haystack, byte[] needle, int offset = 0)
        {
            int success = 0;
            for (int i = offset; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[success])
                {
                    success++;
                }
                else
                {
                    success = 0;
                }

                if (needle.Length == success)
                {
                    return i - needle.Length + 1;
                }
            }
            return -1;
        }

        #endregion
    }
}
