namespace System.Xml;

internal class BinHexDecoder : IncrementalReadDecoder
{
	private Byte[] buffer; //Field offset: 0x10
	private int curIndex; //Field offset: 0x18
	private int endIndex; //Field offset: 0x1C
	private bool hasHalfByteCached; //Field offset: 0x20
	private byte cachedHalfByte; //Field offset: 0x21

	internal virtual bool IsFull
	{
		internal get { } //Length: 10
	}

	internal virtual int Decode(Char[] chars, int startPos, int len) { }

	public static Byte[] Decode(Char[] chars, bool allowOddChars) { }

	private static void Decode(Char* pChars, Char* pCharsEndPos, Byte* pBytes, Byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }

	internal virtual bool get_IsFull() { }

}

