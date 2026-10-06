namespace System.Threading.Tasks;

[FriendAccessAllowed]
internal static class AsyncCausalityTracer
{

	[FriendAccessAllowed]
	internal static bool LoggingOn
	{
		[FriendAccessAllowed]
		internal get { } //Length: 3
	}

	[FriendAccessAllowed]
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowed]
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	[FriendAccessAllowed]
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

}

