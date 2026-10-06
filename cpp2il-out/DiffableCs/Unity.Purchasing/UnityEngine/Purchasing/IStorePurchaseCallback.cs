namespace UnityEngine.Purchasing;

public interface IStorePurchaseCallback
{

	public void OnPurchaseDeferred(DeferredOrder deferredOrder) { }

	public void OnPurchaseFailed(FailedOrder failedOrder) { }

	public void OnPurchaseSucceeded(PendingOrder order) { }

}

