namespace System;

public static class Console
{
	private class WindowsConsole
	{
		private sealed class WindowsCancelHandler : MulticastDelegate
		{

			public WindowsCancelHandler(object object, IntPtr method) { }

			public override bool Invoke(int keyCode) { }

		}

		public static bool ctrlHandlerAdded; //Field offset: 0x0
		private static WindowsCancelHandler cancelHandler; //Field offset: 0x8

		private static WindowsConsole() { }

		private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

		private static int GetConsoleCP() { }

		private static int GetConsoleOutputCP() { }

		public static int GetInputCodePage() { }

		public static int GetOutputCodePage() { }

	}

	internal static TextWriter stdout; //Field offset: 0x0
	private static TextWriter stderr; //Field offset: 0x8
	private static TextReader stdin; //Field offset: 0x10
	internal static bool IsRunningOnAndroid; //Field offset: 0x18
	private static Encoding inputEncoding; //Field offset: 0x20
	private static Encoding outputEncoding; //Field offset: 0x28
	private static ConsoleCancelEventHandler cancel_event; //Field offset: 0x30

	public static TextWriter Error
	{
		 get { } //Length: 79
	}

	public static Encoding InputEncoding
	{
		 get { } //Length: 79
	}

	public static TextWriter Out
	{
		 get { } //Length: 78
	}

	public static Encoding OutputEncoding
	{
		 get { } //Length: 79
	}

	private static Console() { }

	private static void DoConsoleCancelEvent() { }

	public static TextWriter get_Error() { }

	public static Encoding get_InputEncoding() { }

	public static TextWriter get_Out() { }

	public static Encoding get_OutputEncoding() { }

	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	public static Stream OpenStandardError(int bufferSize) { }

	public static Stream OpenStandardInput(int bufferSize) { }

	public static Stream OpenStandardOutput(int bufferSize) { }

	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	public static ConsoleKeyInfo ReadKey() { }

	public static void SetError(TextWriter newError) { }

	public static void SetOut(TextWriter newOut) { }

	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	public static void WriteLine(string value) { }

	public static void WriteLine(string format, object arg0) { }

}

