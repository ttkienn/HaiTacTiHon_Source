namespace UnityEngine.Purchasing;

internal interface IStoreConnectionStateService
{

	public ConnectionState GetConnectionState() { }

	public void SetConnectionState(ConnectionState connectionState) { }

}

