namespace System.Threading.Tasks;

[Extension]
internal static class DebuggerSupport
{
	private static readonly LowLevelDictionary<Int32, Task> s_activeTasks; //Field offset: 0x0
	private static readonly object s_activeTasksLock; //Field offset: 0x8

	public static bool LoggingOn
	{
		 get { } //Length: 3
	}

	private static DebuggerSupport() { }

	public static void AddToActiveTasks(Task task) { }

	private static void AddToActiveTasksNonInlined(Task task) { }

	public static bool get_LoggingOn() { }

	public static void RemoveFromActiveTasks(Task task) { }

	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

}

