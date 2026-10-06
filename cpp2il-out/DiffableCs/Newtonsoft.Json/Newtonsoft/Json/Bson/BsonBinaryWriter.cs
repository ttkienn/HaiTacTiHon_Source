namespace Newtonsoft.Json.Bson;

internal class BsonBinaryWriter
{
	private static readonly Encoding Encoding; //Field offset: 0x0
	private readonly BinaryWriter _writer; //Field offset: 0x10
	private Byte[] _largeByteBuffer; //Field offset: 0x18
	[CompilerGenerated]
	private DateTimeKind <DateTimeKindHandling>k__BackingField; //Field offset: 0x20

	public DateTimeKind DateTimeKindHandling
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static BsonBinaryWriter() { }

	public BsonBinaryWriter(BinaryWriter writer) { }

	private int CalculateSize(int stringByteCount) { }

	private int CalculateSize(BsonToken t) { }

	private int CalculateSizeWithLength(int stringByteCount, bool includeSize) { }

	public void Close() { }

	public void Flush() { }

	[CompilerGenerated]
	public DateTimeKind get_DateTimeKindHandling() { }

	[CompilerGenerated]
	public void set_DateTimeKindHandling(DateTimeKind value) { }

	private void WriteString(string s, int byteCount, Nullable<Int32> calculatedlengthPrefix) { }

	public void WriteToken(BsonToken t) { }

	private void WriteTokenInternal(BsonToken t) { }

	public void WriteUtf8Bytes(string s, int byteCount) { }

}

