namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreConnectUseCase : IStoreConnectUseCase, IStoreConnectCallback
{
	[CompilerGenerated]
	private struct <OnStoreConnectionFailed>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public StoreConnectUseCase <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public StoreConnectionFailureDescription failureDescription; //Field offset: 0x30
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IStore m_Store; //Field offset: 0x10
	private readonly IRetryService m_RetryService; //Field offset: 0x18
	private IRetryPolicy m_RetryPolicyOnDisconnect; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<StoreConnectionFailureDescription> OnStoreDisconnection; //Field offset: 0x28
	[Nullable(2)]
	private TaskCompletionSource<Object> m_CurrentConnectionCompletion; //Field offset: 0x30
	[Nullable(2)]
	private IRetryRequest m_CurrentRequest; //Field offset: 0x38

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<StoreConnectionFailureDescription> OnStoreDisconnection
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	internal StoreConnectUseCase(IStore store, IRetryService retryService, IRetryPolicy retryPolicyOnDisconnect) { }

	[CompilerGenerated]
	public override void add_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value) { }

	public override Task Connect() { }

	private void InitializeRequest() { }

	[AsyncStateMachine(typeof(<OnStoreConnectionFailed>d__12))]
	public override void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription) { }

	public override void OnStoreConnectionSucceeded() { }

	[CompilerGenerated]
	public override void remove_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value) { }

	private void SendDisconnectionEvent(StoreConnectionFailureDescription connectionFailureDescription) { }

	public override void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy) { }

}

