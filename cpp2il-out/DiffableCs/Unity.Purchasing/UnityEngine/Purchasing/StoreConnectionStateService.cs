namespace UnityEngine.Purchasing;

internal class StoreConnectionStateService : IStoreConnectionStateService
{
	private Nullable<ConnectionState> m_StoreConnectionState; //Field offset: 0x10

	public StoreConnectionStateService() { }

	public override ConnectionState GetConnectionState() { }

	public override void SetConnectionState(ConnectionState connectionState) { }

}

