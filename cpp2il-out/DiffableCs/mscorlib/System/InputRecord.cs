namespace System;

internal struct InputRecord
{
	public short EventType; //Field offset: 0x0
	public bool KeyDown; //Field offset: 0x2
	public short RepeatCount; //Field offset: 0x4
	public short VirtualKeyCode; //Field offset: 0x6
	public short VirtualScanCode; //Field offset: 0x8
	public char Character; //Field offset: 0xA
	public int ControlKeyState; //Field offset: 0xC
	private int pad1; //Field offset: 0x10
	private bool pad2; //Field offset: 0x14

}

