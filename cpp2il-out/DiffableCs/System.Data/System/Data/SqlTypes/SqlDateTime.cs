namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable
{
	private static readonly double s_SQLTicksPerMillisecond; //Field offset: 0x0
	public static readonly int SQLTicksPerSecond; //Field offset: 0x8
	public static readonly int SQLTicksPerMinute; //Field offset: 0xC
	public static readonly int SQLTicksPerHour; //Field offset: 0x10
	private static readonly int s_SQLTicksPerDay; //Field offset: 0x14
	private static readonly long s_ticksPerSecond; //Field offset: 0x18
	private static readonly DateTime s_SQLBaseDate; //Field offset: 0x20
	private static readonly long s_SQLBaseDateTicks; //Field offset: 0x28
	private static readonly int s_minYear; //Field offset: 0x30
	private static readonly int s_maxYear; //Field offset: 0x34
	private static readonly int s_minDay; //Field offset: 0x38
	private static readonly int s_maxDay; //Field offset: 0x3C
	private static readonly int s_minTime; //Field offset: 0x40
	private static readonly int s_maxTime; //Field offset: 0x44
	private static readonly int s_dayBase; //Field offset: 0x48
	private static readonly Int32[] s_daysToMonth365; //Field offset: 0x50
	private static readonly Int32[] s_daysToMonth366; //Field offset: 0x58
	private static readonly DateTime s_minDateTime; //Field offset: 0x60
	private static readonly DateTime s_maxDateTime; //Field offset: 0x68
	private static readonly TimeSpan s_minTimeSpan; //Field offset: 0x70
	private static readonly TimeSpan s_maxTimeSpan; //Field offset: 0x78
	private static readonly string s_ISO8601_DateTimeFormat; //Field offset: 0x80
	private static readonly String[] s_dateTimeFormats; //Field offset: 0x88
	public static readonly SqlDateTime MinValue; //Field offset: 0x90
	public static readonly SqlDateTime MaxValue; //Field offset: 0x9C
	public static readonly SqlDateTime Null; //Field offset: 0xA8
	private bool m_fNotNull; //Field offset: 0x0
	private int m_day; //Field offset: 0x4
	private int m_time; //Field offset: 0x8

	public int DayTicks
	{
		 get { } //Length: 83
	}

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public int TimeTicks
	{
		 get { } //Length: 83
	}

	public DateTime Value
	{
		 get { } //Length: 166
	}

	private static SqlDateTime() { }

	public SqlDateTime(int dayTicks, int timeTicks) { }

	private SqlDateTime(bool fNull) { }

	public SqlDateTime(DateTime value) { }

	public int CompareTo(SqlDateTime value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	private static SqlDateTime FromDateTime(DateTime value) { }

	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	public int get_DayTicks() { }

	public override bool get_IsNull() { }

	public int get_TimeTicks() { }

	public DateTime get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	public static SqlDateTime op_Implicit(DateTime value) { }

	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	private static DateTime ToDateTime(SqlDateTime value) { }

	public virtual string ToString() { }

	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

}

