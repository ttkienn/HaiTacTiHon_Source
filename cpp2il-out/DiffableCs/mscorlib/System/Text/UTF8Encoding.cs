namespace System.Text;

public class UTF8Encoding : Encoding
{
	private sealed class UTF8Decoder : DecoderNLS
	{
		internal int bits; //Field offset: 0x30

		internal virtual bool HasState
		{
			internal get { } //Length: 8
		}

		public UTF8Decoder(UTF8Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	private sealed class UTF8Encoder : EncoderNLS
	{
		internal int surrogateChar; //Field offset: 0x38

		internal virtual bool HasState
		{
			internal get { } //Length: 8
		}

		public UTF8Encoder(UTF8Encoding encoding) { }

		internal virtual bool get_HasState() { }

		public virtual void Reset() { }

	}

	public sealed class UTF8EncodingSealed : UTF8Encoding
	{

		public virtual ReadOnlySpan<Byte> Preamble
		{
			 get { } //Length: 172
		}

		public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) { }

		public virtual ReadOnlySpan<Byte> get_Preamble() { }

	}

	internal static readonly UTF8EncodingSealed s_default; //Field offset: 0x0
	internal static readonly Byte[] s_preamble; //Field offset: 0x8
	internal readonly bool _emitUTF8Identifier; //Field offset: 0x38
	private bool _isThrowException; //Field offset: 0x39

	public virtual ReadOnlySpan<Byte> Preamble
	{
		 get { } //Length: 309
	}

	private static UTF8Encoding() { }

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	public UTF8Encoding() { }

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) { }

	public virtual bool Equals(object value) { }

	private bool FallbackInvalidByteSequence(ref Byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref Char* pTarget) { }

	private int FallbackInvalidByteSequence(Byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	public virtual ReadOnlySpan<Byte> get_Preamble() { }

	public virtual int GetByteCount(Char[] chars, int index, int count) { }

	public virtual int GetByteCount(string chars) { }

	[CLSCompliant(False)]
	public virtual int GetByteCount(Char* chars, int count) { }

	internal virtual int GetByteCount(Char* chars, int count, EncoderNLS baseEncoder) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[CLSCompliant(False)]
	public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	internal virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	private Byte[] GetBytesUnknown(ref Byte* pSrc, int ch) { }

	[CLSCompliant(False)]
	public virtual int GetCharCount(Byte* bytes, int count) { }

	internal virtual int GetCharCount(Byte* bytes, int count, DecoderNLS baseDecoder) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	internal virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS baseDecoder) { }

	[CLSCompliant(False)]
	public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public virtual int GetHashCode() { }

	public virtual int GetMaxByteCount(int charCount) { }

	public virtual int GetMaxCharCount(int byteCount) { }

	public virtual Byte[] GetPreamble() { }

	public virtual string GetString(Byte[] bytes, int index, int count) { }

	private static bool InRange(int ch, int start, int end) { }

	private static int PtrDiff(Char* a, Char* b) { }

	private static int PtrDiff(Byte* a, Byte* b) { }

	internal virtual void SetDefaultFallbacks() { }

}

