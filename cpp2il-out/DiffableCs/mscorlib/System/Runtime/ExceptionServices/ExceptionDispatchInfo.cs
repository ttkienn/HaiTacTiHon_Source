namespace System.Runtime.ExceptionServices;

public sealed class ExceptionDispatchInfo
{
	private Exception m_Exception; //Field offset: 0x10
	private object m_stackTrace; //Field offset: 0x18

	internal object BinaryStackTraceArray
	{
		internal get { } //Length: 5
	}

	public Exception SourceException
	{
		 get { } //Length: 5
	}

	private ExceptionDispatchInfo(Exception exception) { }

	public static ExceptionDispatchInfo Capture(Exception source) { }

	internal object get_BinaryStackTraceArray() { }

	public Exception get_SourceException() { }

	[StackTraceHidden]
	public void Throw() { }

	[StackTraceHidden]
	public static void Throw(Exception source) { }

}

