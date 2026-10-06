namespace System.Net;

internal class LazyAsyncResult : IAsyncResult
{
	private class ThreadContext
	{
		internal int m_NestedIOCount; //Field offset: 0x10

		public ThreadContext() { }

	}

	[ThreadStatic]
	private static ThreadContext t_ThreadContext; //Field offset: 0x80000000
	private object m_AsyncObject; //Field offset: 0x10
	private object m_AsyncState; //Field offset: 0x18
	private AsyncCallback m_AsyncCallback; //Field offset: 0x20
	private object m_Result; //Field offset: 0x28
	private int m_IntCompleted; //Field offset: 0x30
	private bool m_EndCalled; //Field offset: 0x34
	private bool m_UserEvent; //Field offset: 0x35
	private object m_Event; //Field offset: 0x38

	protected AsyncCallback AsyncCallback
	{
		 get { } //Length: 5
	}

	internal object AsyncObject
	{
		internal get { } //Length: 5
	}

	public override object AsyncState
	{
		 get { } //Length: 5
	}

	public override WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 145
	}

	public override bool CompletedSynchronously
	{
		 get { } //Length: 41
	}

	private static ThreadContext CurrentThreadContext
	{
		private get { } //Length: 145
	}

	internal bool EndCalled
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool InternalPeekCompleted
	{
		internal get { } //Length: 11
	}

	public override bool IsCompleted
	{
		 get { } //Length: 44
	}

	internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack) { }

	protected override void Cleanup() { }

	protected override void Complete(IntPtr userToken) { }

	protected AsyncCallback get_AsyncCallback() { }

	internal object get_AsyncObject() { }

	public override object get_AsyncState() { }

	public override WaitHandle get_AsyncWaitHandle() { }

	public override bool get_CompletedSynchronously() { }

	private static ThreadContext get_CurrentThreadContext() { }

	internal bool get_EndCalled() { }

	internal bool get_InternalPeekCompleted() { }

	public override bool get_IsCompleted() { }

	internal object InternalWaitForCompletion() { }

	internal void InvokeCallback(object result) { }

	internal void InvokeCallback() { }

	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	internal void set_EndCalled(bool value) { }

	private object WaitForCompletion(bool snap) { }

	private void WorkerThreadComplete(object state) { }

}

