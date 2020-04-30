using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class Category
    {
        /// <summary>
        /// Gets or sets the term.
        /// </summary>
        /// <value>
        /// The term.
        /// </value>
        [XmlElement("term")]
        public string Term { get; set; }

        /// <summary>
        /// Gets or sets the scheme.
        /// </summary>
        /// <value>
        /// The scheme.
        /// </value>
        [XmlElement("scheme")]
        public string Scheme { get; set; }
    }
}
