namespace System.Net;

internal class ContextAwareResult : LazyAsyncResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ContextCallback <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Complete>b__17_0(object s) { }

	}

	[Flags]
	private enum StateFlags
	{
		None = 0,
		CaptureIdentity = 1,
		CaptureContext = 2,
		ThreadSafeContextCopy = 4,
		PostBlockStarted = 8,
		PostBlockFinished = 16,
	}

	private ExecutionContext _context; //Field offset: 0x40
	private object _lock; //Field offset: 0x48
	private StateFlags _flags; //Field offset: 0x50

	internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack) { }

	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	protected virtual void Cleanup() { }

	private void CleanupInternal() { }

	protected virtual void Complete(IntPtr userToken) { }

	private void CompleteCallback() { }

	internal bool FinishPostingAsyncOp() { }

	private void SafeCaptureIdentity() { }

	internal object StartPostingAsyncOp() { }

	internal object StartPostingAsyncOp(bool lockCapture) { }

}

