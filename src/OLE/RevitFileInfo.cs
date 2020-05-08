using CodeCave.Revit.Toolkit.OLE;
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

            var properties = GetProperties(filePath);
            if (properties.TryGetValue(KnownRevitInfoProps.FORMAT, out var formatRaw) && int.TryParse(formatRaw, out var format))
                return format;

            throw new InvalidDataException($"Couldn't read format information from the followin file: '{filePath}'");
        }

        /// <summary>
        /// Gets a <see cref="RevitFileInfo" /> instance from the given file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="readProperties">if set to <c>true</c> [read properties].</param>
        /// <param name="readTypes">if set to <c>true</c> [read types].</param>
        /// <returns></returns>
        /// <exception cref="T:System.ArgumentException">filePath is invalid</exception>
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
                var properties = GetProperties(filePath);
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
        internal static Dictionary<string, string> GetProperties(string filePath)
        {
            var basicInfo = OleDataReader.GetRawBytes(filePath, RevitFileMap.OleStreams.BASIC_FILE_INFO);
            var fileProps = new Dictionary<string, string>();

            var asd = new Regex(@"\p{IsCJKUnifiedIdeographs}");

            foreach (var encoding in RevitFileMap.SupportedEncodings)
            {
                var basicInfoString = encoding.GetString(basicInfo)?.TrimEnd('\u0a0d');
                if (asd.IsMatch(basicInfoString))
                    continue;

                using var basicInfoReader = new StringReader(basicInfoString?.Replace("\0", string.Empty));

                // ReSharper disable once RedundantAssignment
                var stringLine = basicInfoReader.ReadLine(); // skip the first line
                while (!string.IsNullOrWhiteSpace(stringLine = basicInfoReader.ReadLine()))
                {
                    var parts = stringLine.Split(new[] { ":" }, StringSplitOptions.None);
                    if (parts.Length != 2 || IsInvalidProperty(parts.FirstOrDefault()))
                        continue;
                    fileProps.Add(parts[0].Trim(), parts[1].Trim());
                }

                if (fileProps.Any())
                    break;
            }

            return fileProps;
        }

        private static bool IsInvalidProperty(string input)
        {
            return input?.Any(c => char.IsControl(c)) ?? true;
        }

        #endregion
    }
}
