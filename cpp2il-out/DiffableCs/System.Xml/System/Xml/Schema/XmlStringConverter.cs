namespace System.Xml.Schema;

internal class XmlStringConverter : XmlBaseConverter
{

	protected XmlStringConverter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

