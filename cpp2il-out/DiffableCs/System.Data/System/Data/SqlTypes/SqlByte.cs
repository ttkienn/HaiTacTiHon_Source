namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlByte : INullable, IComparable, IXmlSerializable
{
	private static readonly int s_iBitNotByteMax; //Field offset: 0x0
	public static readonly SqlByte Null; //Field offset: 0x4
	public static readonly SqlByte Zero; //Field offset: 0x6
	public static readonly SqlByte MinValue; //Field offset: 0x8
	public static readonly SqlByte MaxValue; //Field offset: 0xA
	private bool m_fNotNull; //Field offset: 0x0
	private byte m_value; //Field offset: 0x1

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public byte Value
	{
		 get { } //Length: 84
	}

	private static SqlByte() { }

	private SqlByte(bool fNull) { }

	public SqlByte(byte value) { }

	public int CompareTo(SqlByte value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public byte get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	public static SqlByte op_Explicit(SqlInt64 x) { }

	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	public static SqlByte op_Implicit(byte x) { }

	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public SqlDouble ToSqlDouble() { }

	public SqlInt64 ToSqlInt64() { }

	public virtual string ToString() { }

}

