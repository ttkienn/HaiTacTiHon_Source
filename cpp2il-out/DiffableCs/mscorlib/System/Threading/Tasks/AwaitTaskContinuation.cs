namespace System.Threading.Tasks;

internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
{
	private static ContextCallback s_invokeActionCallback; //Field offset: 0x0
	private readonly ExecutionContext m_capturedContext; //Field offset: 0x10
	protected readonly Action m_action; //Field offset: 0x18

	internal static bool IsValidLocationForInlining
	{
		internal get { } //Length: 312
	}

	internal AwaitTaskContinuation(Action action, bool flowExecutionContext) { }

	protected Task CreateTask(Action<Object> action, object state, TaskScheduler scheduler) { }

	internal static bool get_IsValidLocationForInlining() { }

	protected static ContextCallback GetInvokeActionCallback() { }

	private static void InvokeAction(object state) { }

	public override void MarkAborted(ThreadAbortException e) { }

	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	internal static void UnsafeScheduleAction(Action action) { }

}

