namespace UnityEngine.Purchasing.Extension;

internal interface IInternalStore : IStore
{

	public ConnectionState GetStoreConnectionState() { }

	public void SetStoreConnectionState(ConnectionState connectionState) { }

}

