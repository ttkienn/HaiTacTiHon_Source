namespace System.Diagnostics;

public abstract class TraceFilter
{

	public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, Object[] args, object data1, Object[] data) { }

	internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage) { }

}

