namespace System;

public struct ArgIterator
{
	private IntPtr sig; //Field offset: 0x0
	private IntPtr args; //Field offset: 0x8
	private int next_arg; //Field offset: 0x10
	private int num_args; //Field offset: 0x14

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

}

