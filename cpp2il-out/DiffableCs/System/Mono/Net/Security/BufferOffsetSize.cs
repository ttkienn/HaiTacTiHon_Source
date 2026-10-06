namespace Mono.Net.Security;

internal class BufferOffsetSize
{
	public Byte[] Buffer; //Field offset: 0x10
	public int Offset; //Field offset: 0x18
	public int Size; //Field offset: 0x1C
	public int TotalBytes; //Field offset: 0x20
	public bool Complete; //Field offset: 0x24

	public int EndOffset
	{
		 get { } //Length: 7
	}

	public int Remaining
	{
		 get { } //Length: 32
	}

	public BufferOffsetSize(Byte[] buffer, int offset, int size) { }

	public int get_EndOffset() { }

	public int get_Remaining() { }

	public virtual string ToString() { }

}

