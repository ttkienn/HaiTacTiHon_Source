namespace UnityEngine.Purchasing.Services;

[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreExtendedPurchaseService : PurchaseService, IAppleStoreExtendedPurchaseService, IPurchaseServiceExtension
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		[Nullable(0)]
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		[NullableContext(0)]
		internal bool <DoesOrderContainAnyRevokedProductIds>b__0(CartItem cartItem) { }

	}

	private readonly IAppReceiptUseCase m_AppReceiptUseCase; //Field offset: 0x98
	private readonly IContinuePromotionalPurchasesUseCase m_ContinuePromotionalPurchasesUseCase; //Field offset: 0xA0
	private readonly IPresentCodeRedemptionSheetUseCase m_PresentCodeRedemptionSheetUseCase; //Field offset: 0xA8
	private readonly IRestoreTransactionsUseCase m_RestoreTransactionsUseCase; //Field offset: 0xB0
	private readonly ISetPromotionalPurchaseInterceptorCallbackUseCase m_SetPromotionalPurchaseInterceptorCallbackUseCase; //Field offset: 0xB8
	private readonly ISimulateAskToBuyUseCase m_SimulateAskToBuyUseCase; //Field offset: 0xC0
	private readonly IOnEntitlementRevokedUseCase m_OnEntitlementRevokedUseCase; //Field offset: 0xC8
	private readonly IRefreshAppReceiptUseCase m_RefreshAppReceiptUseCase; //Field offset: 0xD0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<String> OnEntitlementRevoked
	{
		 add { } //Length: 88
		 remove { } //Length: 91
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Product> OnPromotionalPurchaseIntercepted
	{
		 add { } //Length: 88
		 remove { } //Length: 91
	}

	[Nullable(2)]
	public override string appReceipt
	{
		[NullableContext(2)]
		 get { } //Length: 73
	}

	public override bool simulateAskToBuy
	{
		 get { } //Length: 73
		 set { } //Length: 92
	}

	[Preserve]
	internal AppleStoreExtendedPurchaseService(IAppReceiptUseCase appReceiptUseCase, IContinuePromotionalPurchasesUseCase continuePromotionalPurchasesUseCase, IPresentCodeRedemptionSheetUseCase presentCodeRedemptionSheetUseCase, IRestoreTransactionsUseCase restoreTransactionsUseCase, ISetPromotionalPurchaseInterceptorCallbackUseCase setPromotionalPurchaseInterceptorCallbackUseCase, ISimulateAskToBuyUseCase simulateAskToBuyUseCase, IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IOnEntitlementRevokedUseCase onEntitlementRevokedUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient, IRefreshAppReceiptUseCase refreshAppReceiptUseCase) { }

	public override void add_OnEntitlementRevoked(Action<String> value) { }

	public override void add_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	public override void ContinuePromotionalPurchases() { }

	private static bool DoesOrderContainAnyRevokedProductIds(string productId, Order order) { }

	[NullableContext(2)]
	public override string get_appReceipt() { }

	public override bool get_simulateAskToBuy() { }

	private void OnEntitlementOnEntitlementRevokedUseCaseOnOnEntitlementRevoked(string productId) { }

	public override void PresentCodeRedemptionSheet() { }

	public override void RefreshAppReceipt(Action<String> successCallback, Action<String> errorCallback) { }

	public override void remove_OnEntitlementRevoked(Action<String> value) { }

	public override void remove_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	[NullableContext(2)]
	protected virtual void RestoreTransactionsInternal(Action<Boolean, String> callback) { }

	public override void set_simulateAskToBuy(bool value) { }

	public override void SetRefreshAppReceipt(bool refreshAppReceipt) { }

}

