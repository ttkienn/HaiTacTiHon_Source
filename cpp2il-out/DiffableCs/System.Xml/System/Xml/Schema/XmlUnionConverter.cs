namespace System.Xml.Schema;

internal class XmlUnionConverter : XmlBaseConverter
{
	private XmlValueConverter[] converters; //Field offset: 0x28
	private bool hasAtomicMember; //Field offset: 0x30
	private bool hasListMember; //Field offset: 0x31

	protected XmlUnionConverter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

}

