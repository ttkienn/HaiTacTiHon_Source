namespace System.Xml.Schema;

internal class XmlUntypedConverter : XmlListConverter
{
	public static readonly XmlValueConverter Untyped; //Field offset: 0x0
	public static readonly XmlValueConverter UntypedList; //Field offset: 0x8
	private bool allowListToList; //Field offset: 0x30

	private static XmlUntypedConverter() { }

	protected XmlUntypedConverter() { }

	protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(double value, Type destinationType) { }

	public virtual object ChangeType(DateTime value, Type destinationType) { }

	public virtual object ChangeType(bool value, Type destinationType) { }

	public virtual object ChangeType(int value, Type destinationType) { }

	public virtual object ChangeType(long value, Type destinationType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(decimal value, Type destinationType) { }

	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	private bool SupportsType(Type clrType) { }

	public virtual bool ToBoolean(string value) { }

	public virtual bool ToBoolean(object value) { }

	public virtual DateTime ToDateTime(object value) { }

	public virtual DateTime ToDateTime(string value) { }

	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	public virtual decimal ToDecimal(object value) { }

	public virtual decimal ToDecimal(string value) { }

	public virtual double ToDouble(object value) { }

	public virtual double ToDouble(string value) { }

	public virtual int ToInt32(object value) { }

	public virtual int ToInt32(string value) { }

	public virtual long ToInt64(string value) { }

	public virtual long ToInt64(object value) { }

	public virtual float ToSingle(object value) { }

	public virtual float ToSingle(string value) { }

	public virtual string ToString(DateTimeOffset value) { }

	public virtual string ToString(float value) { }

	public virtual string ToString(long value) { }

	public virtual string ToString(int value) { }

	public virtual string ToString(double value) { }

	public virtual string ToString(decimal value) { }

	public virtual string ToString(bool value) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	public virtual string ToString(DateTime value) { }

}

