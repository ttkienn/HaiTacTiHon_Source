namespace System.Threading;

public static class ThreadPool
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public Action<TState> callBack; //Field offset: 0x0

		public <>c__DisplayClass17_0`1() { }

		internal void <QueueUserWorkItem>b__0(object x) { }

	}


	internal static bool IsThreadPoolThread
	{
		internal get { } //Length: 35
	}

	private static void EnsureVMInitialized() { }

	internal static bool get_IsThreadPoolThread() { }

	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	internal static bool NotifyWorkItemComplete() { }

	internal static void NotifyWorkItemProgress() { }

	internal static void NotifyWorkItemProgressNative() { }

	internal static void NotifyWorkItemQueued() { }

	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	public static bool QueueUserWorkItem(Action<TState> callBack, TState state, bool preferLocal) { }

	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true) { }

	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	internal static void ReportThreadStatus(bool isWorking) { }

	internal static bool RequestWorkerThread() { }

	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

}

