using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using OpenMcdf;

namespace CodeCave.Revit.Toolkit.OLE
{
    /// <summary>
    /// A reader for OLE metadata information stored in Revit files
    /// </summary>
    public static class OleDataReader
    {
        /// <summary>
        /// Gets the raw XML data.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <param name="oleStream">The name of the OLE stream.</param>
        /// <param name="enc">The enc.</param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException">Failed to get XML data from OLE metadata of the following file {pathToFile}</exception>
        public static XmlDocument GetRawXml(string pathToFile, string oleStream, Encoding enc = null)
        {
            XmlDocument xmlDocument;

            try
            {
                var stringData = GetRawString(pathToFile, oleStream, enc);
                xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(stringData);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to get XML data from OLE metadata of the following file \"{pathToFile}\"", ex);
            }

            return xmlDocument;
        }

        /// <summary>
        /// Gets the raw string data.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <param name="oleStream">The name of the OLE stream.</param>
        /// <param name="enc">The enc.</param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException">Failed to decode OLE byte data to {enc.EncodingName}-</exception>
        public static string GetRawString(string pathToFile, string oleStream, Encoding enc = null)
        {
            string stringData;
            enc = (enc ?? Encoding.UTF8);

            try
            {
                var rawData = GetRawBytes(pathToFile, oleStream);
                stringData = enc.GetString(rawData);
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to decode OLE byte data to {enc.EncodingName}-encoded string", ex);
            }

            return stringData;
        }

        /// <summary>
        /// Gets the raw byte data.
        /// </summary>
        /// <param name="compoundFile">The compound file.</param>
        /// <param name="oleStream">The OLE stream.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">compoundFile</exception>
        /// <exception cref="ArgumentException">oleStream</exception>
        /// <exception cref="InvalidDataException">
        /// The following stream \"{oleStream}\" does not exist
        /// or
        /// Failed to get raw OLE byte data
        /// </exception>
        private static byte[] GetRawBytes(CompoundFile compoundFile, string oleStream)
        {
            if (compoundFile is null)
                throw new ArgumentNullException(nameof(compoundFile));

            if (string.IsNullOrWhiteSpace(oleStream))
                throw new ArgumentException(nameof(oleStream));

            byte[] bytes;
            try
            {
                var rootStorage = compoundFile.RootStorage;
                var basicInfoStream = rootStorage.GetStream(oleStream);
                if (basicInfoStream == null)
                {
                    throw new InvalidDataException($"The following stream \"{oleStream}\" does not exist");
                }

                bytes = basicInfoStream.GetData();
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to get raw OLE byte data", ex);
            }
            finally
            {
                compoundFile?.Close();
            }

            return bytes;
        }

        /// <summary>
        /// Gets the raw byte data.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <param name="oleStream">The name of the OLE stream.</param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException">
        /// The following stream \"{oleStream}\" does not exist in this file \"{pathToFile}\
        /// or
        /// Failed to get raw OLE byte data from the following file {pathToFile}
        /// </exception>
        public static byte[] GetRawBytes(string pathToFile, string oleStream)
        {
            if (string.IsNullOrWhiteSpace(pathToFile))
                throw new ArgumentException(nameof(pathToFile));

            try
            {
                var compoundFile = new CompoundFile(pathToFile);
                var bytes = GetRawBytes(compoundFile, oleStream);

                return bytes;
            }
            catch(Exception ex)
            {
                throw new InvalidDataException($"Failed to parse OLE data in the following file '{pathToFile}'", ex);
            }
        }

        public static byte[] GetRawBytes(MemoryStream memoryStream, string oleStream)
        {
            if (memoryStream is null)
                throw new ArgumentNullException(nameof(memoryStream));

            var compoundFile = new CompoundFile(memoryStream);
            var bytes = GetRawBytes(compoundFile, oleStream);

            return bytes;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="pathToFile">The path to file.</param>
        /// <param name="oleStream">The name of the OLE stream.</param>
        /// <param name="enc">The enc.</param>
        /// <returns></returns>
        /// <exception cref="InvalidDataException">Failed to get OLE data of type 'TResult' data from the following file {pathToFile}",</exception>
        public static TResult GetData<TResult>(string pathToFile, string oleStream, Encoding enc = null)
            where TResult : class
        {
            TResult resultObject;

            try
            {
                var stringData = GetRawString(pathToFile, oleStream, enc);
                var xmlSerializer = new XmlSerializer(typeof(TResult));
                using var stringReader = new StringReader(stringData);
                using var xmlReader = XmlReader.Create(stringReader);
                resultObject = xmlSerializer.Deserialize(xmlReader) as TResult;
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to get OLE data of type {typeof(TResult).Name} data from the following file \"{pathToFile}\"", ex);
            }

            return resultObject;
        }
    }
}
