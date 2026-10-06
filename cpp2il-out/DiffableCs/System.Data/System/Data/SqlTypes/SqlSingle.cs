namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlSingle : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlSingle Null; //Field offset: 0x0
	public static readonly SqlSingle Zero; //Field offset: 0x8
	public static readonly SqlSingle MinValue; //Field offset: 0x10
	public static readonly SqlSingle MaxValue; //Field offset: 0x18
	private bool _fNotNull; //Field offset: 0x0
	private float _value; //Field offset: 0x4

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public float Value
	{
		 get { } //Length: 85
	}

	private static SqlSingle() { }

	public SqlSingle(double value) { }

	private SqlSingle(bool fNull) { }

	public SqlSingle(float value) { }

	public int CompareTo(SqlSingle value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public float get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Explicit(SqlDouble x) { }

	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Implicit(SqlDecimal x) { }

	public static SqlSingle op_Implicit(float x) { }

	public static SqlSingle op_Implicit(SqlInt64 x) { }

	public static SqlSingle op_Implicit(SqlByte x) { }

	public static SqlSingle op_Implicit(SqlMoney x) { }

	public static SqlSingle op_Implicit(SqlInt16 x) { }

	public static SqlSingle op_Implicit(SqlInt32 x) { }

	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public SqlDouble ToSqlDouble() { }

	public virtual string ToString() { }

}

