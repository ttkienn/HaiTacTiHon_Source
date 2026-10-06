namespace System.Xml.Serialization;

internal class XmlSerializableMapping : XmlTypeMapping
{
	private XmlSchema _schema; //Field offset: 0x78
	private XmlSchemaComplexType _schemaType; //Field offset: 0x80
	private XmlQualifiedName _schemaTypeName; //Field offset: 0x88

	internal XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

}

