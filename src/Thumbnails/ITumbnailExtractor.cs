using System.IO;

namespace CodeCave.Revit.Toolkit.Thumbnails
{
    /// <summary>
    /// Defines methods of thumbnail extractor object,
    /// which is supposed to extract thumbnails from 3D models without relying on proprietary APIs
    /// </summary>
    public interface IThumbnailExtractor
    {
        /// <summary>
        /// Extracts thumbnail to an image object.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns>Image object</returns>
        byte[] ExtractImageBytes(string pathToFile);

        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns>Memory stream containing thumbnail data</returns>
        MemoryStream ExtractStream(string pathToFile);

        /// <summary>
        /// Extracts thumbnail to a stream.
        /// </summary>
        /// <param name="memoryStream">OLE memory stream.</param>
        /// <returns></returns>
        MemoryStream ExtractStream(MemoryStream memoryStream);

        /// <summary>
        /// Tries to extract thumbnail to an image file.
        /// </summary>
        /// <param name="srcFile">The source file.</param>
        /// <param name="outFile">The output image file.</param>
        /// <returns>true if thumbnail has been extracted successfully</returns>
        bool TryExtractFile(string srcFile, string outFile);
    }
}
