namespace System.Xml.Schema;

internal class XmlNumeric10Converter : XmlBaseConverter
{

	protected XmlNumeric10Converter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(long value, Type destinationType) { }

	public virtual object ChangeType(int value, Type destinationType) { }

	public virtual object ChangeType(decimal value, Type destinationType) { }

	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	public virtual decimal ToDecimal(object value) { }

	public virtual decimal ToDecimal(string value) { }

	public virtual int ToInt32(object value) { }

	public virtual int ToInt32(string value) { }

	public virtual int ToInt32(long value) { }

	public virtual long ToInt64(string value) { }

	public virtual long ToInt64(object value) { }

	public virtual long ToInt64(int value) { }

	public virtual string ToString(int value) { }

	public virtual string ToString(long value) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	public virtual string ToString(decimal value) { }

}

