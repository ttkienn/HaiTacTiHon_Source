namespace Newtonsoft.Json.Bson;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonReader : JsonReader
{
	private enum BsonReaderState
	{
		Normal = 0,
		ReferenceStart = 1,
		ReferenceRef = 2,
		ReferenceId = 3,
		CodeWScopeStart = 4,
		CodeWScopeCode = 5,
		CodeWScopeScope = 6,
		CodeWScopeScopeObject = 7,
		CodeWScopeScopeEnd = 8,
	}

	private class ContainerContext
	{
		public readonly BsonType Type; //Field offset: 0x10
		public int Length; //Field offset: 0x14
		public int Position; //Field offset: 0x18

		public ContainerContext(BsonType type) { }

	}

	private const int MaxCharBytesSize = 128; //Field offset: 0x0
	private static readonly Byte[] SeqRange1; //Field offset: 0x0
	private static readonly Byte[] SeqRange2; //Field offset: 0x8
	private static readonly Byte[] SeqRange3; //Field offset: 0x10
	private static readonly Byte[] SeqRange4; //Field offset: 0x18
	private readonly BinaryReader _reader; //Field offset: 0x78
	private readonly List<ContainerContext> _stack; //Field offset: 0x80
	private Byte[] _byteBuffer; //Field offset: 0x88
	private Char[] _charBuffer; //Field offset: 0x90
	private BsonType _currentElementType; //Field offset: 0x98
	private BsonReaderState _bsonReaderState; //Field offset: 0x9C
	private ContainerContext _currentContext; //Field offset: 0xA0
	private bool _readRootValueAsArray; //Field offset: 0xA8
	private bool _jsonNet35BinaryCompatibility; //Field offset: 0xA9
	private DateTimeKind _dateTimeKindHandling; //Field offset: 0xAC

	public DateTimeKind DateTimeKindHandling
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
	public bool JsonNet35BinaryCompatibility
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool ReadRootValueAsArray
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private static BsonReader() { }

	public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	public BsonReader(Stream stream) { }

	public BsonReader(BinaryReader reader) { }

	public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling) { }

	private int BytesInSequence(byte b) { }

	public virtual void Close() { }

	private void EnsureBuffers() { }

	public DateTimeKind get_DateTimeKindHandling() { }

	public bool get_JsonNet35BinaryCompatibility() { }

	public bool get_ReadRootValueAsArray() { }

	private int GetLastFullCharStop(int start) { }

	private string GetString(int length) { }

	private void MovePosition(int count) { }

	private void PopContext() { }

	private void PushContext(ContainerContext newContext) { }

	public virtual bool Read() { }

	private Byte[] ReadBinary(out BsonBinaryType binaryType) { }

	private byte ReadByte() { }

	private Byte[] ReadBytes(int count) { }

	private bool ReadCodeWScope() { }

	private double ReadDouble() { }

	private string ReadElement() { }

	private int ReadInt32() { }

	private long ReadInt64() { }

	private string ReadLengthString() { }

	private bool ReadNormal() { }

	private bool ReadReference() { }

	private string ReadString() { }

	private void ReadType(BsonType type) { }

	private BsonType ReadType() { }

	public void set_DateTimeKindHandling(DateTimeKind value) { }

	public void set_JsonNet35BinaryCompatibility(bool value) { }

	public void set_ReadRootValueAsArray(bool value) { }

}

