namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class TaskQueue
{
	[CompilerGenerated]
	private struct <Enqueue>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[Nullable(0)]
		public TaskQueue <>4__this; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 0}])]
		public Func<Task`1<T>> taskGenerator; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		[Nullable(0)]
		private TaskAwaiter<T> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Enqueue>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public TaskQueue <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Func<Task> taskGenerator; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly SemaphoreSlim semaphore; //Field offset: 0x10

	public TaskQueue() { }

	[AsyncStateMachine(typeof(<Enqueue>d__2`1))]
	public Task<T> Enqueue(Func<Task`1<T>> taskGenerator) { }

	[AsyncStateMachine(typeof(<Enqueue>d__3))]
	public Task Enqueue(Func<Task> taskGenerator) { }

}

