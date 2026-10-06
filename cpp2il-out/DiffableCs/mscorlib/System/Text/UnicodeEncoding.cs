namespace System.Text;

public class UnicodeEncoding : Encoding
{
	private sealed class Decoder : DecoderNLS
	{
		internal int lastByte; //Field offset: 0x30
		internal char lastChar; //Field offset: 0x34

		internal virtual bool HasState
		{
			internal get { } //Length: 18
		}

		public Decoder(UnicodeEncoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	internal static readonly UnicodeEncoding s_bigEndianDefault; //Field offset: 0x0
	internal static readonly UnicodeEncoding s_littleEndianDefault; //Field offset: 0x8
	private static readonly Byte[] s_bigEndianPreamble; //Field offset: 0x10
	private static readonly Byte[] s_littleEndianPreamble; //Field offset: 0x18
	private static readonly ulong highLowPatternMask; //Field offset: 0x20
	internal bool isThrowException; //Field offset: 0x38
	internal bool bigEndian; //Field offset: 0x39
	internal bool byteOrderMark; //Field offset: 0x3A

	public virtual ReadOnlySpan<Byte> Preamble
	{
		 get { } //Length: 2825
	}

	private static UnicodeEncoding() { }

	public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	public UnicodeEncoding() { }

	public UnicodeEncoding(bool bigEndian, bool byteOrderMark) { }

	public virtual bool Equals(object value) { }

	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetByteCount(string s) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(Char* chars, int count) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[CLSCompliant(False)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetHashCode() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual Byte[] GetPreamble() { }

	public virtual string GetString(Byte[] bytes, int index, int count) { }

	internal virtual void SetDefaultFallbacks() { }

}

