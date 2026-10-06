namespace System.Xml;

internal abstract class Base64Encoder
{
	private Byte[] leftOverBytes; //Field offset: 0x10
	private int leftOverBytesCount; //Field offset: 0x18
	private Char[] charsLine; //Field offset: 0x20

	internal Base64Encoder() { }

	internal void Encode(Byte[] buffer, int index, int count) { }

	internal void Flush() { }

	internal abstract void WriteChars(Char[] chars, int index, int count) { }

}

