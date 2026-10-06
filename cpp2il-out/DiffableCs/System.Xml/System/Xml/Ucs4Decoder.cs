namespace System.Xml;

internal abstract class Ucs4Decoder : Decoder
{
	internal Byte[] lastBytes; //Field offset: 0x20
	internal int lastBytesCount; //Field offset: 0x28

	protected Ucs4Decoder() { }

	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	internal abstract int GetFullChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	internal void Ucs4ToUTF16(uint code, Char[] chars, int charIndex) { }

}

