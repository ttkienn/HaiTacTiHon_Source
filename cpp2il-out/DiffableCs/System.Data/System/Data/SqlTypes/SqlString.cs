namespace System.Data.SqlTypes;

[XmlSchemaProvider("GetXsdType")]
public struct SqlString : INullable, IComparable, IXmlSerializable
{
	public static readonly SqlString Null; //Field offset: 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; //Field offset: 0x20
	public static readonly int IgnoreCase; //Field offset: 0x28
	public static readonly int IgnoreWidth; //Field offset: 0x2C
	public static readonly int IgnoreNonSpace; //Field offset: 0x30
	public static readonly int IgnoreKanaType; //Field offset: 0x34
	public static readonly int BinarySort; //Field offset: 0x38
	public static readonly int BinarySort2; //Field offset: 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; //Field offset: 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; //Field offset: 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; //Field offset: 0x48
	internal static readonly int s_lcidUSEnglish; //Field offset: 0x4C
	private static readonly int s_lcidBinary; //Field offset: 0x50
	private string m_value; //Field offset: 0x0
	private CompareInfo m_cmpInfo; //Field offset: 0x8
	private int m_lcid; //Field offset: 0x10
	private SqlCompareOptions m_flag; //Field offset: 0x14
	private bool m_fNotNull; //Field offset: 0x18

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public string Value
	{
		 get { } //Length: 129
	}

	private static SqlString() { }

	private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	private SqlString(bool fNull) { }

	public SqlString(string data, int lcid, SqlCompareOptions compareOptions) { }

	public SqlString(string data) { }

	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	private static int CompareBinary(SqlString x, SqlString y) { }

	private static int CompareBinary2(SqlString x, SqlString y) { }

	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	public int CompareTo(SqlString value) { }

	public override int CompareTo(object value) { }

	public virtual bool Equals(object value) { }

	private bool FBinarySort() { }

	public override bool get_IsNull() { }

	public string get_Value() { }

	public virtual int GetHashCode() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	public static SqlString op_Addition(SqlString x, SqlString y) { }

	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	public static SqlString op_Implicit(string x) { }

	private void SetCompareInfo() { }

	private static int StringCompare(SqlString x, SqlString y) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	public virtual string ToString() { }

	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

}

