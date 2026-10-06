namespace System;

internal struct ConsoleScreenBufferInfo
{
	public Coord Size; //Field offset: 0x0
	public Coord CursorPosition; //Field offset: 0x4
	public short Attribute; //Field offset: 0x8
	public SmallRect Window; //Field offset: 0xA
	public Coord MaxWindowSize; //Field offset: 0x12

}

