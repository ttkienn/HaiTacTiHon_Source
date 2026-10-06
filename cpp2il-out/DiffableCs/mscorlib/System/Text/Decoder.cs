namespace System.Text;

public abstract class Decoder
{
	internal DecoderFallback _fallback; //Field offset: 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; //Field offset: 0x18

	public DecoderFallback Fallback
	{
		 get { } //Length: 5
	}

	public DecoderFallbackBuffer FallbackBuffer
	{
		 get { } //Length: 119
	}

	internal bool InternalHasFallbackBuffer
	{
		internal get { } //Length: 9
	}

	protected Decoder() { }

	public override void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	public override void Convert(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public DecoderFallback get_Fallback() { }

	public DecoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	public override int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	public override int GetCharCount(Byte* bytes, int count, bool flush) { }

	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	public override int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

	public override int GetChars(ReadOnlySpan<Byte> bytes, Span<Char> chars, bool flush) { }

	public override void Reset() { }

}

