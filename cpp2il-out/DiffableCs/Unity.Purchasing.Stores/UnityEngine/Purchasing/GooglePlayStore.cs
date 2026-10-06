namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStore : InternalStore, IGooglePlayStore, IStore
{
	private readonly IGooglePlayStoreConnectionService m_ConnectionService; //Field offset: 0x58
	private readonly IGooglePlayStoreFetchProductsService m_FetchProductsService; //Field offset: 0x60
	private readonly IGooglePlayStorePurchaseService m_StorePurchaseService; //Field offset: 0x68
	private readonly IGooglePlayStoreFetchPurchasesService m_PlayStoreFetchPurchasesService; //Field offset: 0x70
	private readonly IGooglePlayStoreCheckEntitlementService m_CheckEntitlementsService; //Field offset: 0x78
	private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService; //Field offset: 0x80
	private readonly IGooglePlayStoreChangeSubscriptionService m_ChangeSubscriptionService; //Field offset: 0x88
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; //Field offset: 0x90
	private readonly ICartValidator m_CartValidator; //Field offset: 0x98
	internal IGoogleBillingClient m_BillingClient; //Field offset: 0xA0

	[Preserve]
	internal GooglePlayStore(IGooglePlayStoreFetchProductsService fetchProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGooglePlayStoreFetchPurchasesService playStoreFetchPurchasesService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePlayStoreChangeSubscriptionService changeSubscriptionService, IGooglePlayStoreCheckEntitlementService checkEntitlementsService, IGooglePurchaseCallback googlePurchaseCallback, ICartValidator cartValidator, IGooglePlayStoreConnectionService connectionService, IGoogleBillingClient billingClient) { }

	public override void ChangeSubscription(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	public virtual void CheckEntitlement(ProductDefinition product) { }

	public virtual void Connect() { }

	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public virtual void FetchPurchases() { }

	private void FetchPurchasesInternal() { }

	public virtual void FinishTransaction(PendingOrder pendingOrder) { }

	public override IGooglePurchase GetGooglePurchase(string purchaseToken) { }

	public override void OnPause(bool isPaused) { }

	public virtual void Purchase(ICart cart) { }

	public override void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback) { }

	public virtual void SetEntitlementCheckCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

	public virtual void SetProductsCallback(IStoreProductsCallback productsCallback) { }

	public virtual void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	public virtual void SetPurchaseConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	public virtual void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchPurchaseCallback) { }

	public virtual void SetStoreConnectionCallback(IStoreConnectCallback storeConnectCallback) { }

}

