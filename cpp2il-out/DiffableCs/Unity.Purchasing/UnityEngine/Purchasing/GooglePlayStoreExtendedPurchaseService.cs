namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreExtendedPurchaseService : PurchaseService, IGooglePlayStoreExtendedPurchaseService, IPurchaseServiceExtension
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(0)]
		public Product oldProduct; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		[NullableContext(0)]
		internal bool <UpgradeDowngradeSubscription>b__0(Order order) { }

	}

	private readonly IGooglePlayChangeSubscriptionUseCase m_GooglePlayChangeSubscriptionUseCase; //Field offset: 0x98
	private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase; //Field offset: 0xA0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate
	{
		 add { } //Length: 91
		 remove { } //Length: 91
	}

	[Preserve]
	internal GooglePlayStoreExtendedPurchaseService(IGooglePlayChangeSubscriptionUseCase googlePlayChangeSubscriptionUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient) { }

	public override void add_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

	public override string GetObfuscatedAccountId(Order order) { }

	public override string GetObfuscatedProfileId(Order order) { }

	public override Nullable<GooglePurchaseState> GetPurchaseState(Order order) { }

	public override bool IsOrderDeferred(Order order) { }

	public override void remove_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

	[NullableContext(2)]
	protected virtual void RestoreTransactionsInternal(Action<Boolean, String> callback) { }

	public override void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct) { }

	public override void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayProrationMode desiredProrationMode) { }

	public override void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayReplacementMode desiredReplacementMode) { }

	public override void UpgradeDowngradeSubscription(Order order, Product newProduct, GooglePlayReplacementMode desiredReplacementMode) { }

}

