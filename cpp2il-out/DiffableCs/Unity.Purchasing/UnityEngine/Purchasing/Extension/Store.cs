namespace UnityEngine.Purchasing.Extension;

[Nullable(0)]
[NullableContext(1)]
public abstract class Store : IStore
{
	[Nullable(2)]
	protected IStoreProductsCallback ProductsCallback; //Field offset: 0x10
	[Nullable(2)]
	protected IStorePurchaseFetchCallback PurchaseFetchCallback; //Field offset: 0x18
	[Nullable(2)]
	protected IStorePurchaseCallback PurchaseCallback; //Field offset: 0x20
	[Nullable(2)]
	protected IStorePurchaseConfirmCallback ConfirmCallback; //Field offset: 0x28
	[Nullable(2)]
	protected IStoreCheckEntitlementCallback EntitlementCallback; //Field offset: 0x30
	[Nullable(2)]
	protected IStoreConnectCallback ConnectCallback; //Field offset: 0x38
	[Nullable(2)]
	protected IOnEntitlementRevokedCallback EntitlementRevokedCallback; //Field offset: 0x40
	internal IProductCache ProductCache; //Field offset: 0x48

	protected Store() { }

	public abstract void CheckEntitlement(ProductDefinition product) { }

	public abstract void Connect() { }

	public abstract void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public abstract void FetchPurchases() { }

	public abstract void FinishTransaction(PendingOrder pendingOrder) { }

	public abstract void Purchase(ICart cart) { }

	public override void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

	public override void SetOnRevokedEntitlementCallback(IOnEntitlementRevokedCallback entitlementRevokedCallback) { }

	public override void SetProductsCallback(IStoreProductsCallback productsCallback) { }

	public override void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	public override void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback) { }

	public override void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

}

