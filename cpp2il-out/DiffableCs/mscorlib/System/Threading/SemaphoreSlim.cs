namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
public class SemaphoreSlim : IDisposable
{
	[CompilerGenerated]
	private struct <WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public TaskNode asyncWaiter; //Field offset: 0x28
		public int millisecondsTimeout; //Field offset: 0x30
		public SemaphoreSlim <>4__this; //Field offset: 0x38
		private CancellationTokenSource <cts>5__2; //Field offset: 0x40
		private object <>7__wrap2; //Field offset: 0x48
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class TaskNode : Task<Boolean>, IThreadPoolWorkItem
	{
		internal TaskNode Prev; //Field offset: 0x58
		internal TaskNode Next; //Field offset: 0x60

		internal TaskNode() { }

		private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

		private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	}

	private static readonly Task<Boolean> s_trueTask; //Field offset: 0x0
	private static readonly Task<Boolean> s_falseTask; //Field offset: 0x8
	private static Action<Object> s_cancellationTokenCanceledEventHandler; //Field offset: 0x10
	private int m_currentCount; //Field offset: 0x10
	private readonly int m_maxCount; //Field offset: 0x14
	private int m_waitCount; //Field offset: 0x18
	private object m_lockObj; //Field offset: 0x20
	private ManualResetEvent m_waitHandle; //Field offset: 0x28
	private TaskNode m_asyncHead; //Field offset: 0x30
	private TaskNode m_asyncTail; //Field offset: 0x38

	private static SemaphoreSlim() { }

	public SemaphoreSlim(int initialCount) { }

	public SemaphoreSlim(int initialCount, int maxCount) { }

	private static void CancellationTokenCanceledEventHandler(object obj) { }

	private void CheckDispose() { }

	private TaskNode CreateAndAddAsyncWaiter() { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	private static string GetResourceString(string str) { }

	private static void QueueWaiterTask(TaskNode waiterTask) { }

	public int Release() { }

	public int Release(int releaseCount) { }

	private bool RemoveAsyncWaiter(TaskNode task) { }

	public void Wait() { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	public Task WaitAsync() { }

	public Task<Boolean> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<WaitUntilCountOrTimeoutAsync>d__32))]
	private Task<Boolean> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

}

