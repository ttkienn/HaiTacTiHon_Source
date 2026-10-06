namespace System.Xml;

internal class UTF16Decoder : Decoder
{
	private bool bigEndian; //Field offset: 0x20
	private int lastByte; //Field offset: 0x24

	public UTF16Decoder(bool bigEndian) { }

	public virtual void Convert(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

	public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

	public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

}

