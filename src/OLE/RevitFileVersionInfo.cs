using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeCave.Revit.Toolkit.OLE
{
    /// <summary>
    /// Represents basic file information about a Revit file (.rfa, .rvt etc)
    /// Such as the version of Revit it was created with
    /// </summary>
    [DebuggerDisplay("Version = {Version}")]
    public class RevitFileVersionInfo
    {
        private const string REVIT_BUILD_REGEX = @"^Revit Build\:(.*Revit(\w|\s)*)? (?<version>\d{4})";
        private static readonly Regex RevitBuildRegex;

        /// <summary>
        /// Gets Revit version.
        /// </summary>
        /// <value>
        /// Revit version.
        /// </value>
        public int Version { get; }

        /// <summary>
        /// Initializes the <see cref="RevitFileVersionInfo"/> class.
        /// </summary>
        static RevitFileVersionInfo()
        {
            RevitBuildRegex = new Regex(REVIT_BUILD_REGEX, RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevitFileVersionInfo"/> class.
        /// </summary>
        /// <param name="version">The string representation of Revit version.</param>
        /// <exception cref="ArgumentException">
        /// The following version must be a non-empty string, castable to int
        /// or
        /// Failed to parse the version
        /// </exception>
        internal RevitFileVersionInfo(string version)
        {
            if (string.IsNullOrWhiteSpace(version) || !int.TryParse(version, out int versionInt))
                throw new ArgumentException($"The following {nameof(version)} must be a non-empty string, castable to int");

            // Revit file has 2008 format or earlier
            if (versionInt > 2000 && versionInt < 2009)
                versionInt = 2009;

            Version = versionInt;
        }

        /// <summary>
        /// Reads BasicFileInfo from a Revit file.
        /// </summary>
        /// <param name="pathToFile">The path to Revit file.</param>
        /// <returns><see cref="RevitFileVersionInfo"/> object</returns>
        public static RevitFileVersionInfo ReadFromFile(string pathToFile)
        {
            var content = OleDataReader.GetRawString(pathToFile, nameof(RevitFileVersionInfo), Encoding.Unicode);
            var match = RevitBuildRegex.Match(content);
            return new RevitFileVersionInfo(match.Groups["version"]?.ToString());
        }
    }
}
