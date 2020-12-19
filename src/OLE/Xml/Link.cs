using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class Link
    {
        [XmlElement("design-file", Namespace = "urn:schemas-autodesk-com:partatom")]
        public DesignFile[] Files { get; set;}
    }
}