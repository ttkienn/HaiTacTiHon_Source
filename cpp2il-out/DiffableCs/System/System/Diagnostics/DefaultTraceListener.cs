namespace System.Diagnostics;

public class DefaultTraceListener : TraceListener
{
	private static readonly bool OnWin32; //Field offset: 0x0
	private static readonly string MonoTracePrefix; //Field offset: 0x8
	private static readonly string MonoTraceFile; //Field offset: 0x10
	private string logFileName; //Field offset: 0x38

	[MonoTODO]
	public string LogFileName
	{
		 get { } //Length: 5
	}

	private static DefaultTraceListener() { }

	public DefaultTraceListener() { }

	public string get_LogFileName() { }

	private static string GetPrefix(string var, string target) { }

	public virtual void Write(string message) { }

	private void WriteDebugString(string message) { }

	private void WriteImpl(string message) { }

	public virtual void WriteLine(string message) { }

	private void WriteLogFile(string message, string logFile) { }

	private void WriteMonoTrace(string message) { }

	private void WritePrefix() { }

	private static void WriteWindowsDebugString(Char* message) { }

}

