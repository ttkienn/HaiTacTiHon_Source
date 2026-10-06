namespace UnityEngine.Purchasing;

internal class FakeStore : JsonStore, INativeStore
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ConfirmedOrder, IEnumerable`1<CartItem>> <>9__21_0; //Field offset: 0x8
		public static Func<CartItem, Product> <>9__21_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<CartItem> <CheckIfProductEntitled>b__21_0(ConfirmedOrder order) { }

		internal Product <CheckIfProductEntitled>b__21_1(CartItem item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public FakeStore <>4__this; //Field offset: 0x10
		public List<ProductDescription> products; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <StoreFetchProducts>g__handleAllowInitializeOrFetchProducts|0(bool allow, ProductFetchFailureReason failureReason) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public FakeStore <>4__this; //Field offset: 0x10
		public ProductDefinition productDefinition; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <FakePurchase>g__handleAllowPurchase|0(bool allow, PurchaseFailureReason failureReason) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public ProductDefinition definition; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <CheckIfProductEntitled>b__2(Product product) { }

	}

	internal enum DialogType
	{
		Purchase = 0,
		FetchProducts = 1,
	}

	public const string Name = "fake"; //Field offset: 0x0
	private readonly List<ConfirmedOrder> m_ConfirmedOrders; //Field offset: 0x98
	[CompilerGenerated]
	private string <unavailableProductId>k__BackingField; //Field offset: 0xA0
	public FakeStoreUIMode UIMode; //Field offset: 0xA8
	public bool purchaseCalled; //Field offset: 0xAC
	public bool restoreCalled; //Field offset: 0xAD

	public string unavailableProductId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public FakeStore(ICartValidator cartValidator, ILogger logger) { }

	[CompilerGenerated]
	[DebuggerHidden]
	[NullableContext(1)]
	private void <>n__0(string id, string receipt, string transactionID) { }

	public override bool CheckEntitlement(string productJSON) { }

	private bool CheckIfProductEntitled(ProductDefinition definition) { }

	public virtual void Connect() { }

	private void FakePurchase(ProductDefinition productDefinition, string developerPayload) { }

	public override void FetchExistingPurchases() { }

	public override void FetchProducts(string json) { }

	public override void FinishTransaction(string productJSON, string transactionID) { }

	[CompilerGenerated]
	public string get_unavailableProductId() { }

	private ProductMetadata GetOrCreateProductMetadata(string productId) { }

	private ProductDefinition ParseProductDefinition(string productJSON) { }

	private ProductType ParseProductType(Dictionary<String, Object> dictionary) { }

	public override void Purchase(string productJson, string optionsJson) { }

	public void RestoreTransactions(Action<Boolean, String> callback) { }

	[CompilerGenerated]
	public void set_unavailableProductId(string value) { }

	protected override bool StartUI(object model, DialogType dialogType, Action<Boolean, T> callback) { }

	public void StoreFetchProducts(ReadOnlyCollection<ProductDefinition> productDefinitions) { }

}

