using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    [XmlType(AnonymousType = true)]
    [XmlRoot("entry", Namespace = "http://www.w3.org/2005/Atom")]
    public class PartAtom
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string Category
        {
            get
            {
                if (Categories == null || !Categories.Any())
                    return null;

                var scheme = Categories.First(x => x.Scheme.Equals("adsk:revit:grouping", StringComparison.OrdinalIgnoreCase));
                return (scheme == null)
                    ? null
                    : scheme.Term;
            }
        }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        [XmlElement("category")]
        public Category[] Categories { get; set; }

        /// <summary>
        /// Gets or sets the updated.
        /// </summary>
        /// <value>The updated.</value>
        [XmlElement("updated")]
        public DateTime Updated { get; set; }

        /// <summary>
        /// Gets or sets the family.
        /// </summary>
        /// <value>
        /// The family.
        /// </value>
        [XmlElement("family", Namespace = "urn:schemas-autodesk-com:partatom")]
        public Family Family { get; set; }

        /// <summary>Gets or sets the link.</summary>
        /// <value>The link.</value>
        [XmlElement("link")]
        public Link Link { get; set; }

        /// <summary>
        /// Gets from file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static PartAtom GetFromFile(string filePath)
        {
            var partAtom = OleDataReader.GetData<PartAtom>(filePath, nameof(PartAtom), Encoding.UTF8);
            return partAtom;
        }
    }
}
