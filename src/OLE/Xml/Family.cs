using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class Family
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the variation count.
        /// </summary>
        /// <value>The variation count.</value>
        [XmlElement("variationCount")]
        public int VariationCount { get; set; }

        /// <summary>
        /// Gets or sets the parts.
        /// </summary>
        /// <value>The parts.</value>
        [XmlElement("part")]
        public FamilyType[] Parts { get; set; }
    }
}
