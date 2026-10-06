namespace System.Net;

internal class BufferOffsetSize
{
	internal Byte[] Buffer; //Field offset: 0x10
	internal int Offset; //Field offset: 0x18
	internal int Size; //Field offset: 0x1C

	internal BufferOffsetSize(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	internal BufferOffsetSize(Byte[] buffer, bool copyBuffer) { }

}

