namespace UnityEngine.Purchasing;

internal interface IUnityCallback
{

	public void OnProductsFetched(string json) { }

	public void OnProductsFetchFailed(string jsonFailureDescription) { }

	public void OnPurchaseDeferred(string json) { }

	public void OnPurchaseFailed(string json) { }

	public void OnPurchasesFetched(string json) { }

	public void OnPurchasesRetrievalFailed(string jsonFailureDescription) { }

	public void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	public void OnStoreConnectionFailed(string jsonFailureDescription) { }

	public void OnStoreConnectionSucceeded() { }

}

