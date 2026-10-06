namespace System.Xml;

internal class DomNameTable
{
	private XmlName[] entries; //Field offset: 0x10
	private int count; //Field offset: 0x18
	private int mask; //Field offset: 0x1C
	private XmlDocument ownerDocument; //Field offset: 0x20
	private XmlNameTable nameTable; //Field offset: 0x28

	public DomNameTable(XmlDocument document) { }

	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	private void Grow() { }

}

