namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(2)]
public abstract class ExtensibleStoreService : IStoreService
{
	[Nullable(1)]
	private IStoreService m_BaseInternalStoreService; //Field offset: 0x10

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<StoreConnectionFailureDescription> OnStoreDisconnected
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	public override IAppleStoreExtendedService Apple
	{
		 get { } //Length: 70
	}

	public override IGooglePlayStoreExtendedService Google
	{
		 get { } //Length: 73
	}

	[NullableContext(1)]
	protected ExtensibleStoreService(IStoreService baseStoreService) { }

	public override void add_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	[NullableContext(1)]
	public override Task Connect() { }

	public override IAppleStoreExtendedService get_Apple() { }

	public override IGooglePlayStoreExtendedService get_Google() { }

	public override void remove_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	public override void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy) { }

}

