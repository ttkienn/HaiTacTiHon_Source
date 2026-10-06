namespace System.Xml.Schema;

internal class XmlNumeric2Converter : XmlBaseConverter
{

	protected XmlNumeric2Converter(XmlSchemaType schemaType) { }

	public virtual object ChangeType(double value, Type destinationType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	public virtual double ToDouble(string value) { }

	public virtual double ToDouble(object value) { }

	public virtual float ToSingle(double value) { }

	public virtual float ToSingle(string value) { }

	public virtual float ToSingle(object value) { }

	public virtual string ToString(double value) { }

	public virtual string ToString(float value) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

