namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class RetryRequest : IRetryRequest
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		private struct <<RunTaskOnMainThread>g__RunRequestAndSetResult|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			[Nullable(0)]
			public <>c__DisplayClass7_0 <>4__this; //Field offset: 0x28
			[Nullable(0)]
			private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Func<Task`1<Boolean>> function; //Field offset: 0x10
		[Nullable(0)]
		public TaskCompletionSource<Boolean> completionSource; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		[AsyncStateMachine(typeof(<<RunTaskOnMainThread>g__RunRequestAndSetResult|0>d))]
		internal void <RunTaskOnMainThread>g__RunRequestAndSetResult|0() { }

	}

	[CompilerGenerated]
	private struct <InvokeFromMainThread>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public RetryRequest <>4__this; //Field offset: 0x20
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Retry>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public IRetryableRequestFailureDescription requestFailureDescription; //Field offset: 0x20
		[Nullable(0)]
		public RetryRequest <>4__this; //Field offset: 0x28
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetryFromMainThread>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public RetryRequest <>4__this; //Field offset: 0x20
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private float m_StartTime; //Field offset: 0x10
	private int m_NumberOfAttempts; //Field offset: 0x14
	private readonly Action m_Request; //Field offset: 0x18
	private readonly IRetryPolicy m_RetryPolicy; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28

	public RetryRequest(Action request, IRetryPolicy retryPolicy, IUtil util) { }

	private void FirstTry() { }

	public override Task<Boolean> Invoke() { }

	[AsyncStateMachine(typeof(<InvokeFromMainThread>d__8))]
	private Task<Boolean> InvokeFromMainThread() { }

	[AsyncStateMachine(typeof(<Retry>d__10))]
	public override Task<Boolean> Retry(IRetryableRequestFailureDescription requestFailureDescription) { }

	[AsyncStateMachine(typeof(<RetryFromMainThread>d__11))]
	private Task<Boolean> RetryFromMainThread() { }

	public Task<Boolean> RunTaskOnMainThread(Func<Task`1<Boolean>> function) { }

}

