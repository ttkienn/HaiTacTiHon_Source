namespace System.Diagnostics;

[ComVisible(True)]
public sealed class Debugger
{
	public static readonly string DefaultCategory; //Field offset: 0x0

	private static Debugger() { }

	public static bool IsLogging() { }

	public static void Log(int level, string category, string message) { }

	private static void Log_icall(int level, ref string category, ref string message) { }

	public static void NotifyOfCrossThreadDependency() { }

}

