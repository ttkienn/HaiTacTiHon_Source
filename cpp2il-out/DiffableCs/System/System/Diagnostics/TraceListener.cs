namespace System.Diagnostics;

public abstract class TraceListener : MarshalByRefObject, IDisposable
{
	private int indentLevel; //Field offset: 0x18
	private int indentSize; //Field offset: 0x1C
	private TraceOptions traceOptions; //Field offset: 0x20
	private bool needIndent; //Field offset: 0x24
	private string listenerName; //Field offset: 0x28
	private TraceFilter filter; //Field offset: 0x30

	[ComVisible(False)]
	public TraceFilter Filter
	{
		 get { } //Length: 5
	}

	public int IndentLevel
	{
		 set { } //Length: 29
	}

	public int IndentSize
	{
		 set { } //Length: 187
	}

	public override bool IsThreadSafe
	{
		 get { } //Length: 3
	}

	protected bool NeedIndent
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[ComVisible(False)]
	public TraceOptions TraceOutputOptions
	{
		 get { } //Length: 4
	}

	protected TraceListener(string name) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override void Flush() { }

	public TraceFilter get_Filter() { }

	public override bool get_IsThreadSafe() { }

	protected bool get_NeedIndent() { }

	public TraceOptions get_TraceOutputOptions() { }

	internal bool IsEnabled(TraceOptions opts) { }

	public void set_IndentLevel(int value) { }

	public void set_IndentSize(int value) { }

	protected void set_NeedIndent(bool value) { }

	[ComVisible(False)]
	public override void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	public abstract void Write(string message) { }

	private void WriteFooter(TraceEventCache eventCache) { }

	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	protected override void WriteIndent() { }

	public abstract void WriteLine(string message) { }

}

