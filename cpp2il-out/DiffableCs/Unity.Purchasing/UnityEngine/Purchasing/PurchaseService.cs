namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class PurchaseService : IPurchaseService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		[Nullable(0)]
		public ICart pendingOrderItems; //Field offset: 0x10

		public <>c__DisplayClass40_0() { }

		[NullableContext(0)]
		internal bool <RemoveDeferredOrders>b__0(DeferredOrder deferredOrder) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		[Nullable(0)]
		public PendingOrder order; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		[NullableContext(0)]
		internal bool <ConfirmPurchaseValidations>b__0(ConfirmedOrder p) { }

	}

	private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase; //Field offset: 0x10
	private readonly IPurchaseUseCase m_PurchaseUseCase; //Field offset: 0x18
	private readonly IConfirmOrderUseCase m_ConfirmOrderUseCase; //Field offset: 0x20
	private readonly ICheckEntitlementUseCase m_CheckEntitlementUseCase; //Field offset: 0x28
	internal readonly ObservableCollection<Order> m_Purchases; //Field offset: 0x30
	private readonly ReadOnlyObservableCollection<Order> m_PurchasesReadOnly; //Field offset: 0x38
	private readonly IStoreWrapper m_StoreWrapper; //Field offset: 0x40
	private readonly IAnalyticsClient m_AnalyticsClient; //Field offset: 0x48
	private bool m_ProcessFetchedPendingOrders; //Field offset: 0x50
	private readonly HashSet<String> m_PurchasesProcessedInSession; //Field offset: 0x58
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<PendingOrder> OnPurchasePending; //Field offset: 0x60
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Order> OnPurchaseConfirmed; //Field offset: 0x68
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<FailedOrder> OnPurchaseFailed; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<DeferredOrder> OnPurchaseDeferred; //Field offset: 0x78
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Orders> OnPurchasesFetched; //Field offset: 0x80
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed; //Field offset: 0x88
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Entitlement> OnCheckEntitlement; //Field offset: 0x90

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Entitlement> OnCheckEntitlement
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Order> OnPurchaseConfirmed
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<DeferredOrder> OnPurchaseDeferred
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<FailedOrder> OnPurchaseFailed
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<PendingOrder> OnPurchasePending
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Orders> OnPurchasesFetched
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	[Nullable(2)]
	public override IAppleStoreExtendedPurchaseService Apple
	{
		[NullableContext(2)]
		 get { } //Length: 57
	}

	[Nullable(2)]
	public override IGooglePlayStoreExtendedPurchaseService Google
	{
		[NullableContext(2)]
		 get { } //Length: 57
	}

	internal PurchaseService(IFetchPurchasesUseCase fetchPurchasesUseCase, IPurchaseUseCase purchaseUseCase, IConfirmOrderUseCase confirmOrderUseCase, ICheckEntitlementUseCase checkEntitlementUseCase, IStoreWrapper storeWrapper, IAnalyticsClient analyticsClient) { }

	[CompilerGenerated]
	[NullableContext(0)]
	private void <ConfirmPurchase>b__43_0(PendingOrder pendingOrder, Order resultOrder) { }

	[CompilerGenerated]
	public override void add_OnCheckEntitlement(Action<Entitlement> value) { }

	[CompilerGenerated]
	public override void add_OnPurchaseConfirmed(Action<Order> value) { }

	[CompilerGenerated]
	public override void add_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public override void add_OnPurchaseFailed(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public override void add_OnPurchasePending(Action<PendingOrder> value) { }

	[CompilerGenerated]
	public override void add_OnPurchasesFetched(Action<Orders> value) { }

	[CompilerGenerated]
	public override void add_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	public override void CheckEntitlement(Product product) { }

	public override void ConfirmPurchase(PendingOrder order) { }

	private FailedOrder ConfirmPurchaseValidations(PendingOrder order) { }

	public override void FetchPurchases() { }

	[NullableContext(2)]
	public override IAppleStoreExtendedPurchaseService get_Apple() { }

	[NullableContext(2)]
	public override IGooglePlayStoreExtendedPurchaseService get_Google() { }

	public override ReadOnlyObservableCollection<Order> GetPurchases() { }

	internal bool IsStoreConnected() { }

	private void OnConfirmFailed(FailedOrder failedOrder) { }

	private void OnConfirmSucceeded(PendingOrder pendingOrder, ConfirmedOrder confirmedOrder) { }

	private void OnEntitlementChecked(Entitlement entitlement) { }

	private void OnFetchFailure(PurchasesFetchFailureDescription fetchFailed) { }

	private void OnFetchSuccess(Orders fetchedPurchases) { }

	private void ProcessPendingOrder(PendingOrder fetchedPurchase) { }

	public override void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess) { }

	public override void Purchase(ICart cart) { }

	private void PurchaseDeferred(DeferredOrder order) { }

	internal void PurchaseFailed(FailedOrder order) { }

	public override void PurchaseProduct(Product product) { }

	private void PurchaseSucceeded(PendingOrder order) { }

	[CompilerGenerated]
	public override void remove_OnCheckEntitlement(Action<Entitlement> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseConfirmed(Action<Order> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseFailed(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchasePending(Action<PendingOrder> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchasesFetched(Action<Orders> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	private void RemoveDeferredOrders(PendingOrder pendingOrder) { }

	[NullableContext(2)]
	public override void RestoreTransactions(Action<Boolean, String> callback) { }

	[NullableContext(2)]
	protected override void RestoreTransactionsInternal(Action<Boolean, String> callback) { }

	private void UpdateEntitlementOrder(Entitlement entitlement) { }

	private bool WasPurchaseAlreadyProcessed(string transactionId) { }

}

