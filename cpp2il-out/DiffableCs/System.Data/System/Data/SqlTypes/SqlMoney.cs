namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlMoney : INullable, IComparable, IXmlSerializable
{
	internal static readonly int s_iMoneyScale; //Field offset: 0x0
	private static readonly long s_lTickBase; //Field offset: 0x8
	private static readonly double s_dTickBase; //Field offset: 0x10
	private static readonly long s_minLong; //Field offset: 0x18
	private static readonly long s_maxLong; //Field offset: 0x20
	public static readonly SqlMoney Null; //Field offset: 0x28
	public static readonly SqlMoney Zero; //Field offset: 0x38
	public static readonly SqlMoney MinValue; //Field offset: 0x48
	public static readonly SqlMoney MaxValue; //Field offset: 0x58
	private bool _fNotNull; //Field offset: 0x0
	private long _value; //Field offset: 0x8

	public override bool IsNull
	{
		 get { } //Length: 7
	}

	public decimal Value
	{
		 get { } //Length: 162
	}

	private static SqlMoney() { }

	public SqlMoney(decimal value) { }

	public SqlMoney(long value) { }

	private SqlMoney(bool fNull) { }

	internal SqlMoney(long value, int ignored) { }

	public SqlMoney(int value) { }

	public int CompareTo(SqlMoney value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public decimal get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Explicit(SqlDecimal x) { }

	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Implicit(SqlInt64 x) { }

	public static SqlMoney op_Implicit(SqlByte x) { }

	public static SqlMoney op_Implicit(decimal x) { }

	public static SqlMoney op_Implicit(SqlInt32 x) { }

	public static SqlMoney op_Implicit(long x) { }

	public static SqlMoney op_Implicit(SqlInt16 x) { }

	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public decimal ToDecimal() { }

	public double ToDouble() { }

	public SqlDecimal ToSqlDecimal() { }

	public SqlDouble ToSqlDouble() { }

	public virtual string ToString() { }

}

