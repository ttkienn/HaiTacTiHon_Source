namespace System.Xml.Schema;

internal class XmlMiscConverter : XmlBaseConverter
{

	protected XmlMiscConverter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

