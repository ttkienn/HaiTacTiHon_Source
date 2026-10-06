namespace System.Diagnostics;

internal static class TraceInternal
{
	[ThreadStatic]
	private static int indentLevel; //Field offset: 0x80000000
	private static string appName; //Field offset: 0x0
	private static TraceListenerCollection listeners; //Field offset: 0x8
	private static bool autoFlush; //Field offset: 0x10
	private static int indentSize; //Field offset: 0x14
	internal static readonly object critSec; //Field offset: 0x18

	public static bool AutoFlush
	{
		 get { } //Length: 90
	}

	public static int IndentLevel
	{
		 get { } //Length: 72
	}

	public static int IndentSize
	{
		 get { } //Length: 88
	}

	public static TraceListenerCollection Listeners
	{
		 get { } //Length: 768
	}

	private static TraceInternal() { }

	public static bool get_AutoFlush() { }

	public static int get_IndentLevel() { }

	public static int get_IndentSize() { }

	public static TraceListenerCollection get_Listeners() { }

	private static void InitializeSettings() { }

}

