namespace UnityEngine.Purchasing;

[NullableContext(2)]
public interface IStoreService
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<StoreConnectionFailureDescription> OnStoreDisconnected
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IAppleStoreExtendedService Apple
	{
		 get { } //Length: 0
	}

	public IGooglePlayStoreExtendedService Google
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	[NullableContext(1)]
	public Task Connect() { }

	public IAppleStoreExtendedService get_Apple() { }

	public IGooglePlayStoreExtendedService get_Google() { }

	[CompilerGenerated]
	public void remove_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	public void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy) { }

}

