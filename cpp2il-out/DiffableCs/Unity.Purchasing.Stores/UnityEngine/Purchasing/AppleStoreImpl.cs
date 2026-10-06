namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreImpl : JsonStore, IAppleStoreCallbacks, IAppleAppReceiptViewer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<KeyValuePair`2<String, Object>, String> <>9__53_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<KeyValuePair`2<String, Object>, String> <>9__53_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal string <OnFetchStorePromotionVisibilitySucceeded>b__53_0(KeyValuePair<String, Object> k) { }

		[NullableContext(0)]
		internal string <OnFetchStorePromotionVisibilitySucceeded>b__53_1(KeyValuePair<String, Object> k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		[Nullable(0)]
		public INativeAppleStore apple; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal void <SetNativeStore>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public IntPtr subjectPtr; //Field offset: 0x10
		public IntPtr payloadPtr; //Field offset: 0x18
		public int entitlementStatus; //Field offset: 0x20

		public <>c__DisplayClass55_0() { }

		internal void <MessageCallback>b__0() { }

	}

	[CompilerGenerated]
	private struct <FetchProducts>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public AppleStoreImpl <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<ProductDescription>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnPurchaseSucceeded>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public AppleStoreImpl <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public string purchaseDetailsJson; //Field offset: 0x30
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static HashSet<String> s_SubscriptionDeduplicationData; //Field offset: 0x0
	[Nullable(2)]
	private static IUtil s_Util; //Field offset: 0x8
	[Nullable(2)]
	private static AppleStoreImpl s_Instance; //Field offset: 0x10
	[Nullable(2)]
	private Action<Boolean> m_ObsoleteRestoreCallback; //Field offset: 0x98
	[Nullable(2)]
	private Action<Boolean, String> m_RestoreCallback; //Field offset: 0xA0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String> m_FetchStorePromotionOrderError; //Field offset: 0xA8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Action<List`1<Product>> m_FetchStorePromotionOrderSuccess; //Field offset: 0xB0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String> m_FetchStorePromotionVisibilityError; //Field offset: 0xB8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String, AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess; //Field offset: 0xC0
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String> m_RefreshAppReceiptSuccessCallback; //Field offset: 0xC8
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<String> m_RefreshAppReceiptErrorCallback; //Field offset: 0xD0
	[Nullable(2)]
	private TaskCompletionSource<Boolean> m_RefreshAppReceiptTask; //Field offset: 0xD8
	private bool m_RefreshAppReceipt; //Field offset: 0xE0
	[Nullable(2)]
	private INativeAppleStore m_Native; //Field offset: 0xE8
	private readonly IAppleFetchProductsService m_FetchProductsService; //Field offset: 0xF0
	private readonly ITransactionLog m_TransactionLog; //Field offset: 0xF8
	[Nullable(2)]
	private string appReceipt; //Field offset: 0x100
	private bool m_IsTransactionObserverEnabled; //Field offset: 0x108
	private Guid m_AppAccountToken; //Field offset: 0x10C
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<Product> OnPromotionalPurchaseIntercepted; //Field offset: 0x120
	[CompilerGenerated]
	private bool <simulateAskToBuy>k__BackingField; //Field offset: 0x128

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Product> OnPromotionalPurchaseIntercepted
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public override bool simulateAskToBuy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private static AppleStoreImpl() { }

	protected AppleStoreImpl(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(ProductDefinition productDefinition, string transactionId) { }

	[CompilerGenerated]
	public override void add_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	private void AddSubscriptionDeduplicationData(string productId, string expirationDate) { }

	[NullableContext(2)]
	public override string AppReceipt() { }

	public virtual void CheckEntitlement(ProductDefinition productDefinition) { }

	public override void ClearTransactionLog() { }

	public virtual void Connect() { }

	private string ConvertPtrToString(IntPtr subjectPtr) { }

	private List<Order> CreateOrdersFromFetchedPurchases(Dictionary<String, Dictionary`2<String, Object>> fetchedPurchases) { }

	private void EnsureConfirmedOrderIsFinished(ConfirmedOrder confirmedOrder) { }

	[AsyncStateMachine(typeof(<FetchProducts>d__30))]
	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public virtual void FetchPurchases() { }

	protected virtual void FinishTransaction(ProductDefinition productDefinition, string transactionId) { }

	private ConfirmedOrder GenerateAppleConfirmedOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	private DeferredOrder GenerateAppleDeferredOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	private PendingOrder GenerateApplePendingOrder(string id, string transactionID, string originalTransactionId, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	private List<Order> GenerateOrdersFromProducts(Dictionary<String, Object> transactions, bool isPending) { }

	[CompilerGenerated]
	public override bool get_simulateAskToBuy() { }

	[NullableContext(2)]
	public INativeAppleStore GetNativeStore() { }

	private bool IsValidPurchaseState(string expirationDate, string productId) { }

	[MonoPInvokeCallback(typeof(UnityPurchasingCallback))]
	private static void MessageCallback(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus) { }

	private void OnAppReceiptRefreshedFailed(string error) { }

	private void OnAppReceiptRetrieved(string receipt) { }

	private void OnCheckEntitlement(string productId, int entitlementStatus) { }

	private void OnEntitlementRevoked(string purchaseDetailsJson) { }

	private void OnFetchStorePromotionOrderFailed(string error) { }

	private void OnFetchStorePromotionOrderSucceeded(string productIds) { }

	private void OnFetchStorePromotionVisibilityFailed(string error) { }

	private void OnFetchStorePromotionVisibilitySucceeded(string result) { }

	private void OnPromotionalPurchaseAttempted(string payload) { }

	public virtual void OnPurchaseDeferred(string productDetails) { }

	public virtual void OnPurchasesFetched(string json) { }

	[AsyncStateMachine(typeof(<OnPurchaseSucceeded>d__64))]
	private void OnPurchaseSucceeded(string purchaseDetailsJson) { }

	private void OnTransactionsRestoredFail(string error) { }

	private void OnTransactionsRestoredSuccess() { }

	private static OwnershipType OwnershipTypeFromString(string ownershipTypeString) { }

	private void ProcessCallbackMessage(IntPtr subjectPtr, IntPtr payloadPtr, int entitlementStatus) { }

	private void ProcessLoggedPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	private void ProcessNewPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	private void ProcessValidPurchase(string id, string transactionId, string originalTransactionId, string expirationDate, OwnershipType ownershipType, Nullable<Guid> appAccountToken, string signatureJws) { }

	public virtual void Purchase(ICart cart) { }

	private string PurchaseOptions() { }

	private Task<Boolean> RefreshAppReceiptAsync() { }

	[CompilerGenerated]
	public override void remove_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	private void RevokeEntitlement(string productId) { }

	[CompilerGenerated]
	public override void set_simulateAskToBuy(bool value) { }

	public override void SetAppAccountToken(Guid value) { }

	public override void SetFetchStorePromotionOrderCallbacks(Action<List`1<Product>> successCallback, Action<String> errorCallback) { }

	public override void SetFetchStorePromotionVisibilityCallbacks(Action<String, AppleStorePromotionVisibility> successCallback, Action<String> errorCallback) { }

	public void SetNativeStore(INativeAppleStore apple) { }

	public override void SetRefreshAppReceipt(bool refreshAppReceipt) { }

	public override void SetRefreshAppReceiptCallbacks(Action<String> successCallback, Action<String> errorCallback) { }

	[NullableContext(2)]
	public override void SetRestoreTransactionsCallback(Action<Boolean, String> successCallback) { }

}

