namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public struct SqlBinary : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlBinary Null; //Field offset: 0x0
	private Byte[] _value; //Field offset: 0x0

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public Byte[] Value
	{
		 get { } //Length: 200
	}

	private static SqlBinary() { }

	private SqlBinary(bool fNull) { }

	public SqlBinary(Byte[] value) { }

	public override int CompareTo(object value) { }

	public int CompareTo(SqlBinary value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public Byte[] get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	public static SqlBinary op_Implicit(Byte[] x) { }

	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public virtual string ToString() { }

}

