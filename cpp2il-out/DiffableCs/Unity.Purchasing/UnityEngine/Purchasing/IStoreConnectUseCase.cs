namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IStoreConnectUseCase
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<StoreConnectionFailureDescription> OnStoreDisconnection
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value) { }

	public Task Connect() { }

	[CompilerGenerated]
	public void remove_OnStoreDisconnection(Action<StoreConnectionFailureDescription> value) { }

	public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy) { }

}

