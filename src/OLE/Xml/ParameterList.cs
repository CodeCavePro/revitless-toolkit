using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CodeCave.Revit.Toolkit.OLE
{
    public class ParameterList : List<PartAtomParameter>, IXmlSerializable
    {
        /// <summary>
        /// Generates an object from its XML representation.
        /// </summary>
        /// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> stream from which the object is deserialized.</param>
        public void ReadXml(XmlReader reader)
        {
            if (reader.IsEmptyElement)
            {
                reader.Read();
                return;
            }

            const BuiltInParameterGroup @group = BuiltInParameterGroup.INVALID;
            while (reader.NodeType == XmlNodeType.Element)
            {
                var type = reader.GetAttribute("type");
                var displayName = reader.GetAttribute("displayName") ?? reader.Name;
                var paramType = reader.GetAttribute("typeOfParameter").FromSharedDataType();
                var unitSymbol = reader.GetAttribute("units").TryGetFromSymbol(out var unitSymbolType)
                    ? unitSymbolType
                    : UnitSymbolType.UST_NONE;
                var units = unitSymbol.TryGetFromUnitSymbol(out var displayUnitType)
                        ? displayUnitType
                        : DisplayUnitType.DUT_CUSTOM;

                var partAtomParam = new PartAtomParameter(reader.Name, paramType, group, units)
                {
                    Type = type,
                    Name = displayName,
                    ParameterType = paramType,
                    UnitType = paramType.GetUnitType(),
                    ValueRaw = reader.ReadInnerXml()
                };

                Add(partAtomParam);
            }
        }

        /// <summary>
        /// This method is reserved and should not be used. When implementing the IXmlSerializable interface, you should return null (Nothing in Visual Basic) from this method, and instead, if specifying a custom schema is required, apply the <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute" /> to the class.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.
        /// </returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> stream to which the object is serialized.</param>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
