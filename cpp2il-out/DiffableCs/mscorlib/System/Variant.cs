namespace System;

internal struct Variant
{
	public short vt; //Field offset: 0x0
	public ushort wReserved1; //Field offset: 0x2
	public ushort wReserved2; //Field offset: 0x4
	public ushort wReserved3; //Field offset: 0x6
	public uint uintVal; //Field offset: 0x8
	public int intVal; //Field offset: 0x8
	public ulong ullVal; //Field offset: 0x8
	public uint ulVal; //Field offset: 0x8
	public ushort uiVal; //Field offset: 0x8
	public sbyte cVal; //Field offset: 0x8
	public IntPtr bstrVal; //Field offset: 0x8
	public double dblVal; //Field offset: 0x8
	public IntPtr pdispVal; //Field offset: 0x8
	public float fltVal; //Field offset: 0x8
	public short iVal; //Field offset: 0x8
	public byte bVal; //Field offset: 0x8
	public int lVal; //Field offset: 0x8
	public long llVal; //Field offset: 0x8
	public short boolVal; //Field offset: 0x8
	public BRECORD bRecord; //Field offset: 0x8

	public void Clear() { }

}

