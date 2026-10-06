namespace System.Xml;

internal class ByteStack
{
	private Byte[] stack; //Field offset: 0x10
	private int growthRate; //Field offset: 0x18
	private int top; //Field offset: 0x1C
	private int size; //Field offset: 0x20

	public ByteStack(int growthRate) { }

	public byte Pop() { }

	public void Push(byte data) { }

}

