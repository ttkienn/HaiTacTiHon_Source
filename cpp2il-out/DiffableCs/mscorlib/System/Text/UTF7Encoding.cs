namespace System.Text;

public class UTF7Encoding : Encoding
{
	private sealed class Decoder : DecoderNLS
	{
		internal int bits; //Field offset: 0x30
		internal int bitCount; //Field offset: 0x34
		internal bool firstByte; //Field offset: 0x38

		internal virtual bool HasState
		{
			internal get { } //Length: 8
		}

		public Decoder(UTF7Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	private sealed class DecoderUTF7Fallback : DecoderFallback
	{

		public virtual int MaxCharCount
		{
			 get { } //Length: 6
		}

		public DecoderUTF7Fallback() { }

		public virtual DecoderFallbackBuffer CreateFallbackBuffer() { }

		public virtual bool Equals(object value) { }

		public virtual int get_MaxCharCount() { }

		public virtual int GetHashCode() { }

	}

	private sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		private char cFallback; //Field offset: 0x20
		private int iCount; //Field offset: 0x24
		private int iSize; //Field offset: 0x28

		public virtual int Remaining
		{
			 get { } //Length: 13
		}

		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback) { }

		public virtual bool Fallback(Byte[] bytesUnknown, int index) { }

		public virtual int get_Remaining() { }

		public virtual char GetNextChar() { }

		internal virtual int InternalFallback(Byte[] bytes, Byte* pBytes) { }

		public virtual void Reset() { }

	}

	private sealed class Encoder : EncoderNLS
	{
		internal int bits; //Field offset: 0x38
		internal int bitCount; //Field offset: 0x3C

		internal virtual bool HasState
		{
			internal get { } //Length: 17
		}

		public Encoder(UTF7Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	internal static readonly UTF7Encoding s_default; //Field offset: 0x0
	private Byte[] _base64Bytes; //Field offset: 0x38
	private SByte[] _base64Values; //Field offset: 0x40
	private Boolean[] _directEncode; //Field offset: 0x48
	private bool _allowOptionals; //Field offset: 0x50

	private static UTF7Encoding() { }

	public UTF7Encoding() { }

	public UTF7Encoding(bool allowOptionals) { }

	public virtual bool Equals(object value) { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetByteCount(string s) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(Char* chars, int count) { }

	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetHashCode() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual string GetString(Byte[] bytes, int index, int count) { }

	private void MakeTables() { }

	internal virtual void SetDefaultFallbacks() { }

}

