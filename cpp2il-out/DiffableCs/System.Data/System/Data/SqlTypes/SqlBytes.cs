namespace System.Data.SqlTypes;

[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable
{
	internal Byte[] _rgbBuf; //Field offset: 0x10
	private long _lCurLen; //Field offset: 0x18
	internal Stream _stream; //Field offset: 0x20
	private SqlBytesCharsState _state; //Field offset: 0x28
	private Byte[] _rgbWorkBuf; //Field offset: 0x30

	public Byte[] Buffer
	{
		 get { } //Length: 397
	}

	public override bool IsNull
	{
		 get { } //Length: 8
	}

	public long Length
	{
		 get { } //Length: 129
	}

	public static SqlBytes Null
	{
		 get { } //Length: 71
	}

	public Byte[] Value
	{
		 get { } //Length: 565
	}

	public SqlBytes() { }

	public SqlBytes(Byte[] buffer) { }

	public SqlBytes(SqlBinary value) { }

	private void CopyStreamToBuffer() { }

	internal bool FStream() { }

	public Byte[] get_Buffer() { }

	public override bool get_IsNull() { }

	public long get_Length() { }

	public static SqlBytes get_Null() { }

	public Byte[] get_Value() { }

	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	private void SetBuffer(Byte[] buffer) { }

	public void SetNull() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private override XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private override void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	private override void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

}

