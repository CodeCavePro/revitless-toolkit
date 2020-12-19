using System;
using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class DesignFile
    {
        [XmlElement("title", Namespace = "urn:schemas-autodesk-com:partatom")]
        public string Title { get; set; }

        [XmlElement("product", Namespace = "urn:schemas-autodesk-com:partatom")]
        public string Product { get; set; }

        [XmlElement("product-version", Namespace = "urn:schemas-autodesk-com:partatom")]
        public int ProductVersion { get; set; }

        [XmlElement("updated", Namespace = "urn:schemas-autodesk-com:partatom")]
        public DateTime Updated { get; set; }


    }
}