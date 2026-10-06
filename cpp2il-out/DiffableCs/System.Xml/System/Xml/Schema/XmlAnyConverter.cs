namespace System.Xml.Schema;

internal class XmlAnyConverter : XmlBaseConverter
{
	public static readonly XmlValueConverter Item; //Field offset: 0x0
	public static readonly XmlValueConverter AnyAtomic; //Field offset: 0x8

	private static XmlAnyConverter() { }

	protected XmlAnyConverter(XmlTypeCode typeCode) { }

	public virtual object ChangeType(decimal value, Type destinationType) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(long value, Type destinationType) { }

	public virtual object ChangeType(int value, Type destinationType) { }

	public virtual object ChangeType(double value, Type destinationType) { }

	public virtual object ChangeType(bool value, Type destinationType) { }

	public virtual object ChangeType(DateTime value, Type destinationType) { }

	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual bool ToBoolean(object value) { }

	public virtual DateTime ToDateTime(object value) { }

	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	public virtual decimal ToDecimal(object value) { }

	public virtual double ToDouble(object value) { }

	public virtual int ToInt32(object value) { }

	public virtual long ToInt64(object value) { }

	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	public virtual float ToSingle(object value) { }

}

