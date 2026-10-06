namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable
{
	private static readonly int s_MASKI2; //Field offset: 0x0
	public static readonly SqlInt16 Null; //Field offset: 0x4
	public static readonly SqlInt16 Zero; //Field offset: 0x8
	public static readonly SqlInt16 MinValue; //Field offset: 0xC
	public static readonly SqlInt16 MaxValue; //Field offset: 0x10
	private bool m_fNotNull; //Field offset: 0x0
	private short m_value; //Field offset: 0x2

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public short Value
	{
		 get { } //Length: 84
	}

	private static SqlInt16() { }

	private SqlInt16(bool fNull) { }

	public SqlInt16(short value) { }

	public int CompareTo(SqlInt16 value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public short get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_Implicit(short x) { }

	public static SqlInt16 op_Implicit(SqlByte x) { }

	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt64 ToSqlInt64() { }

	public virtual string ToString() { }

}

