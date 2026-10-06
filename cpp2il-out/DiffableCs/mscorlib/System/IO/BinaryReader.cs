namespace System.IO;

[ComVisible(True)]
public class BinaryReader : IDisposable
{
	private Stream m_stream; //Field offset: 0x10
	private Byte[] m_buffer; //Field offset: 0x18
	private Decoder m_decoder; //Field offset: 0x20
	private Byte[] m_charBytes; //Field offset: 0x28
	private Char[] m_singleChar; //Field offset: 0x30
	private Char[] m_charBuffer; //Field offset: 0x38
	private int m_maxCharsSize; //Field offset: 0x40
	private bool m_2BytesPerChar; //Field offset: 0x44
	private bool m_isMemoryStream; //Field offset: 0x45
	private bool m_leaveOpen; //Field offset: 0x46

	public override Stream BaseStream
	{
		 get { } //Length: 5
	}

	public BinaryReader(Stream input) { }

	public BinaryReader(Stream input, Encoding encoding) { }

	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected override void FillBuffer(int numBytes) { }

	public override Stream get_BaseStream() { }

	private int InternalReadChars(Char[] buffer, int index, int count) { }

	private int InternalReadOneChar() { }

	public override int Read() { }

	public override int Read(Byte[] buffer, int index, int count) { }

	protected private int Read7BitEncodedInt() { }

	public override bool ReadBoolean() { }

	public override byte ReadByte() { }

	public override Byte[] ReadBytes(int count) { }

	public override char ReadChar() { }

	public override Char[] ReadChars(int count) { }

	public override decimal ReadDecimal() { }

	public override double ReadDouble() { }

	public override short ReadInt16() { }

	public override int ReadInt32() { }

	public override long ReadInt64() { }

	[CLSCompliant(False)]
	public override sbyte ReadSByte() { }

	public override float ReadSingle() { }

	public override string ReadString() { }

	[CLSCompliant(False)]
	public override ushort ReadUInt16() { }

	[CLSCompliant(False)]
	public override uint ReadUInt32() { }

	[CLSCompliant(False)]
	public override ulong ReadUInt64() { }

}

