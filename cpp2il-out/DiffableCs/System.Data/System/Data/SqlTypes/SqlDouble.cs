namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlDouble : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlDouble Null; //Field offset: 0x0
	public static readonly SqlDouble Zero; //Field offset: 0x10
	public static readonly SqlDouble MinValue; //Field offset: 0x20
	public static readonly SqlDouble MaxValue; //Field offset: 0x30
	private bool m_fNotNull; //Field offset: 0x0
	private double m_value; //Field offset: 0x8

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public double Value
	{
		 get { } //Length: 85
	}

	private static SqlDouble() { }

	private SqlDouble(bool fNull) { }

	public SqlDouble(double value) { }

	public int CompareTo(SqlDouble value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public double get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Implicit(SqlDecimal x) { }

	public static SqlDouble op_Implicit(SqlInt64 x) { }

	public static SqlDouble op_Implicit(SqlInt32 x) { }

	public static SqlDouble op_Implicit(SqlInt16 x) { }

	public static SqlDouble op_Implicit(SqlByte x) { }

	public static SqlDouble op_Implicit(double x) { }

	public static SqlDouble op_Implicit(SqlSingle x) { }

	public static SqlDouble op_Implicit(SqlMoney x) { }

	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public SqlSingle ToSqlSingle() { }

	public virtual string ToString() { }

}

