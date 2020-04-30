using CodeCave.Revit.Toolkit.OLE;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeCave.Revit.Toolkit
{
    public class RevitFileInfo
    {
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

        public Version Version { get; internal set; }

        public string Name { get; internal set; }

        public string Vendor { get; internal set; }

        public object Architecture { get; internal set; }

        public bool Is64Bit { get; internal set; }

        public string FilePath { get; private set; }

        #endregion

        #region Methods

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
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("filePath is invalid");

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
            var basicInfo = OleDataReader.GetRawBytes(filePath, "BasicFileInfo");
            var fileProps = new Dictionary<string, string>();
            var supportedEncodeings = new[]
            {
                Encoding.Unicode,
                Encoding.BigEndianUnicode,
                Encoding.UTF8,
                Encoding.ASCII,
                Encoding.Default,
            };

            foreach (var encoding in supportedEncodeings)
            {
                var basicInfoString = encoding.GetString(basicInfo)?.TrimEnd('\u0a0d');
                using var basicInfoReader = new StringReader(basicInfoString);

                // ReSharper disable once RedundantAssignment
                var stringLine = basicInfoReader.ReadLine(); // skip the first line
                while (!string.IsNullOrWhiteSpace(stringLine = basicInfoReader.ReadLine()))
                {
                    var parts = stringLine.Split(new[] { ":" }, 2, StringSplitOptions.None);
                    if (parts.Length != 2)
                        continue;
                    fileProps.Add(parts[0].Trim(), parts[1].Trim());
                }

                if (fileProps.Any())
                    break;
            }

            return fileProps;
        }

        #endregion
    }
}
