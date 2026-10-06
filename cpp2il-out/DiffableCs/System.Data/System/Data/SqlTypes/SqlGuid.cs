namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlGuid : INullable, IComparable, IXmlSerializable
{
	private static readonly int s_sizeOfGuid; //Field offset: 0x0
	private static readonly Int32[] s_rgiGuidOrder; //Field offset: 0x8
	public static readonly SqlGuid Null; //Field offset: 0x10
	private Byte[] m_value; //Field offset: 0x0

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public Guid Value
	{
		 get { } //Length: 161
	}

	private static SqlGuid() { }

	private SqlGuid(bool fNull) { }

	public SqlGuid(Guid g) { }

	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	public override int CompareTo(object value) { }

	public int CompareTo(SqlGuid value) { }

	public virtual bool Equals(object value) { }

	public override bool get_IsNull() { }

	public Guid get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	public static SqlGuid op_Implicit(Guid x) { }

	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public virtual string ToString() { }

}

