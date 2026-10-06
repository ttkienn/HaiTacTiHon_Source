namespace System;

internal class NullConsoleDriver : IConsoleDriver
{
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; //Field offset: 0x0

	private static NullConsoleDriver() { }

	public NullConsoleDriver() { }

	public override ConsoleKeyInfo ReadKey(bool intercept) { }

}

