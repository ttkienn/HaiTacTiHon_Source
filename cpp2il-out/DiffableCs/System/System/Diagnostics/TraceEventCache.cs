namespace System.Diagnostics;

public class TraceEventCache
{
	private static int processId; //Field offset: 0x0
	private static string processName; //Field offset: 0x8
	private long timeStamp; //Field offset: 0x10
	private DateTime dateTime; //Field offset: 0x18
	private string stackTrace; //Field offset: 0x20

	public string Callstack
	{
		 get { } //Length: 59
	}

	public DateTime DateTime
	{
		 get { } //Length: 149
	}

	public Stack LogicalOperationStack
	{
		 get { } //Length: 348
	}

	public int ProcessId
	{
		 get { } //Length: 70
	}

	public string ThreadId
	{
		 get { } //Length: 112
	}

	public long Timestamp
	{
		 get { } //Length: 84
	}

	public TraceEventCache() { }

	public string get_Callstack() { }

	public DateTime get_DateTime() { }

	public Stack get_LogicalOperationStack() { }

	public int get_ProcessId() { }

	public string get_ThreadId() { }

	public long get_Timestamp() { }

	internal static int GetProcessId() { }

	internal static int GetThreadId() { }

	private static void InitProcessInfo() { }

}

