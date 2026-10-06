namespace System.Xml.Schema;

internal sealed class XmlSchemaCollectionNode
{
	private string namespaceUri; //Field offset: 0x10
	private SchemaInfo schemaInfo; //Field offset: 0x18
	private XmlSchema schema; //Field offset: 0x20

	internal string NamespaceURI
	{
		internal set { } //Length: 13
	}

	internal XmlSchema Schema
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal SchemaInfo SchemaInfo
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public XmlSchemaCollectionNode() { }

	internal XmlSchema get_Schema() { }

	internal SchemaInfo get_SchemaInfo() { }

	internal void set_NamespaceURI(string value) { }

	internal void set_Schema(XmlSchema value) { }

	internal void set_SchemaInfo(SchemaInfo value) { }

}

