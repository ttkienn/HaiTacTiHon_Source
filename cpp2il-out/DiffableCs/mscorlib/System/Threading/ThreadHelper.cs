namespace System.Threading;

internal class ThreadHelper
{
	internal static ContextCallback _ccb; //Field offset: 0x0
	private Delegate _start; //Field offset: 0x10
	private object _startArg; //Field offset: 0x18
	private ExecutionContext _executionContext; //Field offset: 0x20

	private static ThreadHelper() { }

	internal ThreadHelper(Delegate start) { }

	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	internal void ThreadStart(object obj) { }

	internal void ThreadStart() { }

	private static void ThreadStart_Context(object state) { }

}

