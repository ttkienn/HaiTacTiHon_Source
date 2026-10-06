namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable
{
	private static readonly long s_iIntMin; //Field offset: 0x0
	private static readonly long s_lBitNotIntMax; //Field offset: 0x8
	public static readonly SqlInt32 Null; //Field offset: 0x10
	public static readonly SqlInt32 Zero; //Field offset: 0x18
	public static readonly SqlInt32 MinValue; //Field offset: 0x20
	public static readonly SqlInt32 MaxValue; //Field offset: 0x28
	private bool m_fNotNull; //Field offset: 0x0
	private int m_value; //Field offset: 0x4

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public int Value
	{
		 get { } //Length: 128
	}

	private static SqlInt32() { }

	private SqlInt32(bool fNull) { }

	public SqlInt32(int value) { }

	public int CompareTo(SqlInt32 value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public int get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	public static SqlInt32 op_Implicit(SqlByte x) { }

	public static SqlInt32 op_Implicit(int x) { }

	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	private static bool SameSignInt(int x, int y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt64 ToSqlInt64() { }

	public virtual string ToString() { }

}

