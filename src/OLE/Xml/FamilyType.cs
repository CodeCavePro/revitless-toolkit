using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    [XmlRoot(Namespace = "http://www.w3.org/2005/Atom")]
    public class FamilyType
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        /// <value>
        /// The parameters.
        /// </value>
        [XmlAnyElement]
        public ParameterList Parameters { get; set; }
    }
}
