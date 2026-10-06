namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlBoolean True; //Field offset: 0x0
	public static readonly SqlBoolean False; //Field offset: 0x1
	public static readonly SqlBoolean Null; //Field offset: 0x2
	public static readonly SqlBoolean Zero; //Field offset: 0x3
	public static readonly SqlBoolean One; //Field offset: 0x4
	private byte m_value; //Field offset: 0x0

	public byte ByteValue
	{
		 get { } //Length: 131
	}

	public bool IsFalse
	{
		 get { } //Length: 7
	}

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public bool IsTrue
	{
		 get { } //Length: 7
	}

	public bool Value
	{
		 get { } //Length: 95
	}

	private static SqlBoolean() { }

	private SqlBoolean(int value, bool fNull) { }

	public SqlBoolean(bool value) { }

	public SqlBoolean(int value) { }

	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	public int CompareTo(SqlBoolean value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public byte get_ByteValue() { }

	public bool get_IsFalse() { }

	public override bool get_IsNull() { }

	public bool get_IsTrue() { }

	public bool get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	public static SqlBoolean op_Implicit(bool x) { }

	public static bool op_True(SqlBoolean x) { }

	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public virtual string ToString() { }

}

