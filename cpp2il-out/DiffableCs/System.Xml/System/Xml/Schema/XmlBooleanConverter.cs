namespace System.Xml.Schema;

internal class XmlBooleanConverter : XmlBaseConverter
{

	protected XmlBooleanConverter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(bool value, Type destinationType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	public virtual bool ToBoolean(string value) { }

	public virtual bool ToBoolean(object value) { }

	public virtual string ToString(bool value) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

