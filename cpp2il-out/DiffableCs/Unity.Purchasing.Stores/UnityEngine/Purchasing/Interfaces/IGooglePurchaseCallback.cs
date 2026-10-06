namespace UnityEngine.Purchasing.Interfaces;

internal interface IGooglePurchaseCallback
{

	public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

	public void NotifyDeferredPurchase(IGooglePurchase purchase) { }

	public void NotifyUpgradeDowngradeSubscription(string sku) { }

	public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	public void OnPurchaseSuccessful(IGooglePurchase purchase) { }

	public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback) { }

	public void SetProductCache(IProductCache productCache) { }

	public void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback) { }

}

