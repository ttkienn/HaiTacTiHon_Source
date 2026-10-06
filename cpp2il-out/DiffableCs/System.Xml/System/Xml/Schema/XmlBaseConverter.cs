namespace System.Xml.Schema;

internal abstract class XmlBaseConverter : XmlValueConverter
{
	protected static readonly Type ICollectionType; //Field offset: 0x0
	protected static readonly Type IEnumerableType; //Field offset: 0x8
	protected static readonly Type IListType; //Field offset: 0x10
	protected static readonly Type ObjectArrayType; //Field offset: 0x18
	protected static readonly Type StringArrayType; //Field offset: 0x20
	protected static readonly Type XmlAtomicValueArrayType; //Field offset: 0x28
	protected static readonly Type DecimalType; //Field offset: 0x30
	protected static readonly Type Int32Type; //Field offset: 0x38
	protected static readonly Type Int64Type; //Field offset: 0x40
	protected static readonly Type StringType; //Field offset: 0x48
	protected static readonly Type XmlAtomicValueType; //Field offset: 0x50
	protected static readonly Type ObjectType; //Field offset: 0x58
	protected static readonly Type ByteType; //Field offset: 0x60
	protected static readonly Type Int16Type; //Field offset: 0x68
	protected static readonly Type SByteType; //Field offset: 0x70
	protected static readonly Type UInt16Type; //Field offset: 0x78
	protected static readonly Type UInt32Type; //Field offset: 0x80
	protected static readonly Type UInt64Type; //Field offset: 0x88
	protected static readonly Type XPathItemType; //Field offset: 0x90
	protected static readonly Type DoubleType; //Field offset: 0x98
	protected static readonly Type SingleType; //Field offset: 0xA0
	protected static readonly Type DateTimeType; //Field offset: 0xA8
	protected static readonly Type DateTimeOffsetType; //Field offset: 0xB0
	protected static readonly Type BooleanType; //Field offset: 0xB8
	protected static readonly Type ByteArrayType; //Field offset: 0xC0
	protected static readonly Type XmlQualifiedNameType; //Field offset: 0xC8
	protected static readonly Type UriType; //Field offset: 0xD0
	protected static readonly Type TimeSpanType; //Field offset: 0xD8
	protected static readonly Type XPathNavigatorType; //Field offset: 0xE0
	private XmlSchemaType schemaType; //Field offset: 0x10
	private XmlTypeCode typeCode; //Field offset: 0x18
	private Type clrTypeDefault; //Field offset: 0x20

	protected Type DefaultClrType
	{
		 get { } //Length: 5
	}

	protected XmlSchemaType SchemaType
	{
		 get { } //Length: 5
	}

	protected XmlTypeCode TypeCode
	{
		 get { } //Length: 4
	}

	protected string XmlTypeName
	{
		 get { } //Length: 514
	}

	private static XmlBaseConverter() { }

	protected XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	protected XmlBaseConverter(XmlSchemaType schemaType) { }

	protected XmlBaseConverter(XmlTypeCode typeCode) { }

	protected XmlBaseConverter(XmlBaseConverter converterAtomic) { }

	protected static string AnyUriToString(Uri value) { }

	protected static string Base64BinaryToString(Byte[] value) { }

	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(decimal value, Type destinationType) { }

	public virtual object ChangeType(double value, Type destinationType) { }

	public virtual object ChangeType(int value, Type destinationType) { }

	public virtual object ChangeType(long value, Type destinationType) { }

	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	public virtual object ChangeType(object value, Type destinationType) { }

	public virtual object ChangeType(DateTime value, Type destinationType) { }

	public virtual object ChangeType(bool value, Type destinationType) { }

	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	protected static string DateOffsetToString(DateTimeOffset value) { }

	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	protected static string DateTimeToString(DateTime value) { }

	protected static string DateToString(DateTime value) { }

	protected static string DayTimeDurationToString(TimeSpan value) { }

	internal static int DecimalToInt32(decimal value) { }

	protected static long DecimalToInt64(decimal value) { }

	protected static ulong DecimalToUInt64(decimal value) { }

	protected static string DurationToString(TimeSpan value) { }

	protected static string GDayOffsetToString(DateTimeOffset value) { }

	protected static string GDayToString(DateTime value) { }

	protected Type get_DefaultClrType() { }

	protected XmlSchemaType get_SchemaType() { }

	protected XmlTypeCode get_TypeCode() { }

	protected string get_XmlTypeName() { }

	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	protected static string GMonthDayToString(DateTime value) { }

	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	protected static string GMonthToString(DateTime value) { }

	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	protected static string GYearMonthToString(DateTime value) { }

	protected static string GYearOffsetToString(DateTimeOffset value) { }

	protected static string GYearToString(DateTime value) { }

	protected static byte Int32ToByte(int value) { }

	protected static short Int32ToInt16(int value) { }

	protected static sbyte Int32ToSByte(int value) { }

	protected static ushort Int32ToUInt16(int value) { }

	protected static int Int64ToInt32(long value) { }

	protected static uint Int64ToUInt32(long value) { }

	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	protected static string QNameToString(XmlQualifiedName name) { }

	protected static Byte[] StringToBase64Binary(string value) { }

	protected static DateTime StringToDate(string value) { }

	protected static DateTimeOffset StringToDateOffset(string value) { }

	protected static DateTime StringToDateTime(string value) { }

	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	protected static TimeSpan StringToDayTimeDuration(string value) { }

	protected static TimeSpan StringToDuration(string value) { }

	protected static DateTime StringToGDay(string value) { }

	protected static DateTimeOffset StringToGDayOffset(string value) { }

	protected static DateTime StringToGMonth(string value) { }

	protected static DateTime StringToGMonthDay(string value) { }

	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	protected static DateTime StringToGYear(string value) { }

	protected static DateTime StringToGYearMonth(string value) { }

	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	protected static DateTimeOffset StringToGYearOffset(string value) { }

	protected static Byte[] StringToHexBinary(string value) { }

	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	protected static DateTime StringToTime(string value) { }

	protected static DateTimeOffset StringToTimeOffset(string value) { }

	protected static TimeSpan StringToYearMonthDuration(string value) { }

	protected static string TimeOffsetToString(DateTimeOffset value) { }

	protected static string TimeToString(DateTime value) { }

	public virtual bool ToBoolean(object value) { }

	public virtual bool ToBoolean(long value) { }

	public virtual bool ToBoolean(int value) { }

	public virtual bool ToBoolean(double value) { }

	public virtual bool ToBoolean(DateTime value) { }

	public virtual bool ToBoolean(string value) { }

	public virtual DateTime ToDateTime(object value) { }

	public virtual DateTime ToDateTime(DateTimeOffset value) { }

	public virtual DateTime ToDateTime(int value) { }

	public virtual DateTime ToDateTime(double value) { }

	public virtual DateTime ToDateTime(bool value) { }

	public virtual DateTime ToDateTime(string value) { }

	public virtual DateTime ToDateTime(long value) { }

	public virtual DateTimeOffset ToDateTimeOffset(DateTime value) { }

	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	public virtual decimal ToDecimal(string value) { }

	public virtual decimal ToDecimal(object value) { }

	public virtual double ToDouble(long value) { }

	public virtual double ToDouble(object value) { }

	public virtual double ToDouble(int value) { }

	public virtual double ToDouble(DateTime value) { }

	public virtual double ToDouble(bool value) { }

	public virtual double ToDouble(string value) { }

	public virtual int ToInt32(bool value) { }

	public virtual int ToInt32(double value) { }

	public virtual int ToInt32(DateTime value) { }

	public virtual int ToInt32(object value) { }

	public virtual int ToInt32(string value) { }

	public virtual int ToInt32(long value) { }

	public virtual long ToInt64(DateTime value) { }

	public virtual long ToInt64(bool value) { }

	public virtual long ToInt64(double value) { }

	public virtual long ToInt64(int value) { }

	public virtual long ToInt64(string value) { }

	public virtual long ToInt64(object value) { }

	public virtual float ToSingle(double value) { }

	public virtual float ToSingle(string value) { }

	public virtual float ToSingle(object value) { }

	public virtual string ToString(int value) { }

	public virtual string ToString(long value) { }

	public virtual string ToString(float value) { }

	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	public virtual string ToString(DateTimeOffset value) { }

	public virtual string ToString(DateTime value) { }

	public virtual string ToString(bool value) { }

	public virtual string ToString(object value) { }

	public virtual string ToString(decimal value) { }

	public virtual string ToString(double value) { }

	protected static DateTime UntypedAtomicToDateTime(string value) { }

	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	protected static string YearMonthDurationToString(TimeSpan value) { }

}

