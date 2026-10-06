namespace System;

[IsReadOnly]
public struct ConsoleKeyInfo
{
	private readonly char _keyChar; //Field offset: 0x0
	private readonly ConsoleKey _key; //Field offset: 0x4
	private readonly ConsoleModifiers _mods; //Field offset: 0x8

	public ConsoleKey Key
	{
		 get { } //Length: 4
	}

	public char KeyChar
	{
		 get { } //Length: 4
	}

	public ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	public virtual bool Equals(object value) { }

	public bool Equals(ConsoleKeyInfo obj) { }

	public ConsoleKey get_Key() { }

	public char get_KeyChar() { }

	public virtual int GetHashCode() { }

}

