namespace System;

internal static class ConsoleDriver
{
	internal static IConsoleDriver driver; //Field offset: 0x0
	private static bool is_console; //Field offset: 0x8
	private static bool called_isatty; //Field offset: 0x9

	public static bool IsConsole
	{
		 get { } //Length: 346
	}

	private static ConsoleDriver() { }

	private static IConsoleDriver CreateNullConsoleDriver() { }

	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	public static bool get_IsConsole() { }

	internal static int InternalKeyAvailable(int ms_timeout) { }

	private static bool Isatty(IntPtr handle) { }

	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	internal static bool SetEcho(bool wantEcho) { }

	internal static bool TtySetup(string keypadXmit, string teardown, out Byte[] control_characters, out Int32* address) { }

}

