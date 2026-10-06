namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayPurchaseCallback : IGooglePurchaseCallback
{
	[Nullable(2)]
	private IProductCache m_ProductCache; //Field offset: 0x10
	[Nullable(2)]
	private IStorePurchaseCallback m_PurchaseCallback; //Field offset: 0x18
	[Nullable(2)]
	private IStorePurchaseFetchCallback m_PurchaseFetchCallback; //Field offset: 0x20
	[Nullable(2)]
	private IGooglePlayChangeSubscriptionCallback m_ChangeSubscriptionCallback; //Field offset: 0x28
	private readonly IGooglePurchaseConverter m_GooglePurchaseConverter; //Field offset: 0x30
	private readonly IUtil m_Util; //Field offset: 0x38

	[Preserve]
	internal GooglePlayPurchaseCallback(IGooglePurchaseConverter googlePurchaseConverter, IUtil util) { }

	public override void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

	public override void NotifyDeferredPurchase(IGooglePurchase purchase) { }

	public override void NotifyUpgradeDowngradeSubscription(string sku) { }

	private void OnOrderPurchaseSuccessful(Order order) { }

	public override void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	public override void OnPurchaseSuccessful(IGooglePurchase purchase) { }

	public override void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback) { }

	public override void SetProductCache(IProductCache productCache) { }

	public override void SetPurchaseCallback(IStorePurchaseCallback purchaseCallback) { }

	public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback) { }

}

