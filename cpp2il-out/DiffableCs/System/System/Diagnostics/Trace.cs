namespace System.Diagnostics;

public sealed class Trace
{
	private static CorrelationManager correlationManager; //Field offset: 0x0

	public static bool AutoFlush
	{
		 get { } //Length: 136
	}

	public static CorrelationManager CorrelationManager
	{
		 get { } //Length: 173
	}

	public static TraceListenerCollection Listeners
	{
		 get { } //Length: 64
	}

	public static bool get_AutoFlush() { }

	public static CorrelationManager get_CorrelationManager() { }

	public static TraceListenerCollection get_Listeners() { }

}

