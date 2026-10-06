namespace UnityEngine.Purchasing.Extension;

[NullableContext(1)]
internal interface IStore
{

	public void CheckEntitlement(ProductDefinition product) { }

	public void Connect() { }

	public void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public void FetchPurchases() { }

	public void FinishTransaction(PendingOrder pendingOrder) { }

	public void Purchase(ICart cart) { }

	public void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

	public void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback) { }

	public void SetProductsCallback(IStoreProductsCallback productsCallback) { }

	public void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	public void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback) { }

	public void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

}

