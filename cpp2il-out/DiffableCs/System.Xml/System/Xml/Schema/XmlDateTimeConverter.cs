namespace System.Xml.Schema;

internal class XmlDateTimeConverter : XmlBaseConverter
{

	protected XmlDateTimeConverter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(DateTime value, Type destinationType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	public virtual DateTime ToDateTime(DateTimeOffset value) { }

	public virtual DateTime ToDateTime(string value) { }

	public virtual DateTime ToDateTime(object value) { }

	public virtual DateTimeOffset ToDateTimeOffset(DateTime value) { }

	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	public virtual string ToString(DateTime value) { }

	public virtual string ToString(DateTimeOffset value) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

