namespace System.Xml.Schema;

internal class SchemaNamespaceManager : XmlNamespaceManager
{
	private XmlSchemaObject node; //Field offset: 0x50

	public SchemaNamespaceManager(XmlSchemaObject node) { }

	public virtual string LookupNamespace(string prefix) { }

	public virtual string LookupPrefix(string ns) { }

}

