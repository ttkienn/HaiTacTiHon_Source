namespace System.Threading;

internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
{
	internal static ContextCallback ccb; //Field offset: 0x0
	private WaitCallback callback; //Field offset: 0x10
	private ExecutionContext context; //Field offset: 0x18
	private object state; //Field offset: 0x20

	private static QueueUserWorkItemCallback() { }

	internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	private static void WaitCallback_Context(object state) { }

}

