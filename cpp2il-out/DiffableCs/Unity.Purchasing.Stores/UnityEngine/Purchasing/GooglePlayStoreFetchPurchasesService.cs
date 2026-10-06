namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreFetchPurchasesService : IGooglePlayStoreFetchPurchasesService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public static Func<IGooglePurchase, Boolean> <>9__16_0; //Field offset: 0x8
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public static Func<IGooglePurchase, Boolean> <>9__17_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <PurchaseIsPending>b__17_0(IGooglePurchase purchase) { }

		internal bool <PurchaseIsPurchased>b__16_0(IGooglePurchase purchase) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		[Nullable(0)]
		public IGooglePurchase purchase; //Field offset: 0x10
		[Nullable(0)]
		public string purchaseToken; //Field offset: 0x18
		[Nullable(0)]
		public Func<IGooglePurchase, Boolean> <>9__1; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <GetGooglePurchase>b__0(List<IGooglePurchase> googlePurchases) { }

		[NullableContext(0)]
		internal bool <GetGooglePurchase>b__1(IGooglePurchase purchases) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		[Nullable(0)]
		public GooglePlayStoreFetchPurchasesService <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public IGooglePurchase purchase; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		[NullableContext(0)]
		internal Product <BuildProductsFromPurchase>b__0(string sku) { }

		[NullableContext(0)]
		internal Product <BuildProductsFromPurchase>b__1(Product product) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		[Nullable(0)]
		public GooglePlayStoreFetchPurchasesService <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public List<IGooglePurchase> deferredPurchases; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		[NullableContext(0)]
		internal Order <OnPurchasesFetched>b__0(IGooglePurchase purchase) { }

		internal void <OnPurchasesFetched>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<List`1<Product>> onQueryPurchaseSucceed; //Field offset: 0x10
		[Nullable(0)]
		public GooglePlayStoreFetchPurchasesService <>4__this; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <FetchPurchases>b__0(List<IGooglePurchase> googlePurchases) { }

	}

	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x10
	private readonly IGooglePurchaseConverter m_PurchaseConverter; //Field offset: 0x18
	[Nullable(2)]
	private IProductCache m_ProductCache; //Field offset: 0x20
	[Nullable(2)]
	private IStorePurchaseFetchCallback m_FetchCallback; //Field offset: 0x28
	private IUtil m_Util; //Field offset: 0x30

	[Preserve]
	internal GooglePlayStoreFetchPurchasesService(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseConverter purchaseConverter, IUtil util) { }

	private IEnumerable<Product> BuildProductsFromPurchase(IGooglePurchase purchase) { }

	private static Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase) { }

	public override void FetchPurchases() { }

	public override void FetchPurchases(Action<List`1<Product>> onQueryPurchaseSucceed) { }

	private List<Product> FillProductsWithPurchases(IEnumerable<IGooglePurchase> purchases) { }

	public override IGooglePurchase GetGooglePurchase(string purchaseToken) { }

	private void OnPurchasesFetched(List<IGooglePurchase> purchases) { }

	private static Func<IGooglePurchase, Boolean> PurchaseIsPending() { }

	private static Func<IGooglePurchase, Boolean> PurchaseIsPurchased() { }

	[NullableContext(2)]
	private void PurchaseRetrievalFailedForUnknownReasons(string message = null) { }

	public override void SetProductCache(IProductCache productCache) { }

	public override void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback) { }

	private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku) { }

	private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase) { }

	private void UpdateDeferredProductsByPurchases(List<IGooglePurchase> deferredPurchases) { }

}

