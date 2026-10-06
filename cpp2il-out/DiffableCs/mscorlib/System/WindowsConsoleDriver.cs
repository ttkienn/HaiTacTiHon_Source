namespace System;

internal class WindowsConsoleDriver : IConsoleDriver
{
	private IntPtr inputHandle; //Field offset: 0x10
	private IntPtr outputHandle; //Field offset: 0x18
	private short defaultAttribute; //Field offset: 0x20

	public WindowsConsoleDriver() { }

	private static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	private static IntPtr GetStdHandle(Handles handle) { }

	private static bool IsModifierKey(short virtualKeyCode) { }

	private static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

	public override ConsoleKeyInfo ReadKey(bool intercept) { }

}

