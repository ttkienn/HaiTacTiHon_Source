namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IStoreConnectCallback
{

	public void OnStoreConnectionFailed(StoreConnectionFailureDescription failureDescription) { }

	public void OnStoreConnectionSucceeded() { }

}

