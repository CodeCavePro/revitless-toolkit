using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class BasicFileInfo
    {
        private const string REVIT_BUILD_REGEX = @"^Revit Build\:(.*Revit(\w|\s)*)? (?<version>\d{4})";
        private static readonly Regex _revitBuildRegex;

        public RevitVersion Version { get; }

        /// <summary>
        /// Initializes the <see cref="BasicFileInfo"/> class.
        /// </summary>
        static BasicFileInfo()
        {
            _revitBuildRegex = new Regex(REVIT_BUILD_REGEX, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicFileInfo"/> class.
        /// </summary>
        /// <param name="version">The string representation of Revit version.</param>
        /// <exception cref="ArgumentException">
        /// The following version must be a non-empty string, castable to int
        /// or
        /// Failed to parse the version
        /// </exception>
        internal BasicFileInfo(string version)
        {
            int versionInt;
            if (string.IsNullOrWhiteSpace(version) || !int.TryParse(version, out versionInt))
            {
                throw new ArgumentException($"The following {nameof(version)} must be a non-empty string, castable to int");
            }

            // Revit file has 2008 format or earlier
            if (versionInt > 2000 && versionInt < 2009)
            {
                versionInt = 2009;
            }

            if (!Enum.IsDefined(typeof(RevitVersion), versionInt))
            {
                throw new ArgumentException($"Failed to parse the version {nameof(version)}");
            }

            Version = (RevitVersion)versionInt;
        }

        /// <summary>
        /// Reads BasicFileInfo from a Revit file.
        /// </summary>
        /// <param name="pathToFile">The path to Revit file.</param>
        /// <returns><see cref="BasicFileInfo"/> object</returns>
        public static BasicFileInfo ReadFromFile(string pathToFile)
        {
            var content = OleDataReader.GetRawString(pathToFile, "BasicFileInfo", Encoding.Unicode);
            var match = _revitBuildRegex.Match(content);
            return new BasicFileInfo(match?.Groups["version"]?.ToString());
        }
    }
}
