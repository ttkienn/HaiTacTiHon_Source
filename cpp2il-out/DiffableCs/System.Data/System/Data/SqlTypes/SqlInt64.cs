namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable
{
	private static readonly long s_lLowIntMask; //Field offset: 0x0
	private static readonly long s_lHighIntMask; //Field offset: 0x8
	public static readonly SqlInt64 Null; //Field offset: 0x10
	public static readonly SqlInt64 Zero; //Field offset: 0x20
	public static readonly SqlInt64 MinValue; //Field offset: 0x30
	public static readonly SqlInt64 MaxValue; //Field offset: 0x40
	private bool m_fNotNull; //Field offset: 0x0
	private long m_value; //Field offset: 0x8

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public long Value
	{
		 get { } //Length: 84
	}

	private static SqlInt64() { }

	private SqlInt64(bool fNull) { }

	public SqlInt64(long value) { }

	public int CompareTo(SqlInt64 value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public long get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Implicit(long x) { }

	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	public static SqlInt64 op_Implicit(SqlByte x) { }

	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	private static bool SameSignLong(long x, long y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public SqlByte ToSqlByte() { }

	public SqlDecimal ToSqlDecimal() { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt16 ToSqlInt16() { }

	public SqlInt32 ToSqlInt32() { }

	public virtual string ToString() { }

}

