namespace UnityEngine.Purchasing;

internal interface IGooglePlayStoreConnectionService
{

	public GoogleBillingConnectionState CheckConnectionState() { }

	public void Connect() { }

	public bool IsReady() { }

	public void SetConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

}

