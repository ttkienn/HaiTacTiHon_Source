namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
internal class PurchasingManager : IStoreController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public Product product; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <OnPurchasePendingAction>b__0(Product p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Product product; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <OnPurchaseConfirmedAction>b__0(Product p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public Product product; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <OnPurchasesFetchedAction>b__0(Product p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_1
	{
		public Product product; //Field offset: 0x10

		public <>c__DisplayClass17_1() { }

		internal bool <OnPurchasesFetchedAction>b__1(Product p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <FindProductByProductId>b__0(Product product) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public PurchasingManager <>4__this; //Field offset: 0x10
		public Action<List`1<Product>> onFetched; //Field offset: 0x18
		public Action<ProductFetchFailed> onFailed; //Field offset: 0x20
		public Action successCallback; //Field offset: 0x28
		public Action<InitializationFailureReason, String> failCallback; //Field offset: 0x30

		public <>c__DisplayClass21_0() { }

		internal void <FetchAdditionalProducts>b__0(List<Product> _) { }

		internal void <FetchAdditionalProducts>b__1(ProductFetchFailed failed) { }

	}

	[CompilerGenerated]
	private bool <useTransactionLog>k__BackingField; //Field offset: 0x10
	private readonly ITransactionLog m_TransactionLog; //Field offset: 0x18
	private StoreController m_StoreController; //Field offset: 0x20
	[CompilerGenerated]
	private readonly ProductCollection <products>k__BackingField; //Field offset: 0x28

	public override ProductCollection products
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool useTransactionLog
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public PurchasingManager() { }

	public override void ConfirmPendingPurchase(Product product) { }

	private ICart CreateCart(string productId) { }

	private static PendingOrder CreatePendingOrderFromProduct(Product product) { }

	public override void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, String> failCallback) { }

	private Product FindProductByProductId(string productId) { }

	[CompilerGenerated]
	public override ProductCollection get_products() { }

	[CompilerGenerated]
	public bool get_useTransactionLog() { }

	private bool HasRecordedTransaction(string transactionId) { }

	public override void InitiatePurchase(string productId) { }

	public override void InitiatePurchase(Product product) { }

	public override void InitiatePurchase(string productId, string payload) { }

	public override void InitiatePurchase(Product product, string payload) { }

	private void InvokeProcessPurchase(Product product, Order order) { }

	private void OnPurchaseConfirmedAction(Order order) { }

	private static void OnPurchaseFailedAction(FailedOrder failedOrder) { }

	private void OnPurchasePendingAction(PendingOrder pendingOrder) { }

	private void OnPurchasesFetchedAction(Orders orders) { }

	[CompilerGenerated]
	public void set_useTransactionLog(bool value) { }

}

