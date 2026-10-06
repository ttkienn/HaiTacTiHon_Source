namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class JsonStore : InternalStore, IUnityCallback
{
	private const string k_StoreSpecificErrorCodeKey = "storeSpecificErrorCode"; //Field offset: 0x0
	protected ICartValidator m_CartValidator; //Field offset: 0x58
	protected string m_StoreName; //Field offset: 0x60
	[Nullable(2)]
	private INativeStore m_Store; //Field offset: 0x68
	private bool m_IsRefreshing; //Field offset: 0x70
	[Nullable(2)]
	private Action m_RefreshCallback; //Field offset: 0x78
	protected readonly ILogger Logger; //Field offset: 0x80
	[Nullable(2)]
	private PurchaseFailureDescription LastPurchaseFailureDescription; //Field offset: 0x88
	private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode; //Field offset: 0x90

	internal JsonStore(ICartValidator cartValidator, ILogger logger, string storeName) { }

	public ConnectionState CheckConnectionState() { }

	public virtual void CheckEntitlement(ProductDefinition product) { }

	public virtual void Connect() { }

	internal List<Order> CreateOrdersFromFetchedPurchases(List<ProductDescription> productDescriptions) { }

	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public virtual void FetchPurchases() { }

	protected Product FindProductById(string productId) { }

	protected override void FinishTransaction(ProductDefinition productDefinition, string transactionId) { }

	public virtual void FinishTransaction(PendingOrder pendingOrder) { }

	protected ConfirmedOrder GenerateConfirmedOrder(string id, string receipt, string transactionID) { }

	protected DeferredOrder GenerateDeferredOrder(string id, string receipt, string transactionID) { }

	protected PendingOrder GeneratePendingOrder(string id, string receipt, string transactionID) { }

	[NullableContext(2)]
	public PurchaseFailureDescription GetLastPurchaseFailureDescription() { }

	public StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode() { }

	public override void OnProductsFetched(string json) { }

	public override void OnProductsFetchFailed(string jsonFailureDescription) { }

	public override void OnPurchaseDeferred(string productDetails) { }

	public void OnPurchaseFailed(PurchaseFailureDescription failure, string json = null) { }

	public override void OnPurchaseFailed(string json) { }

	public override void OnPurchasesFetched(string json) { }

	public override void OnPurchasesRetrievalFailed(string jsonFailureDescription) { }

	public override void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	public override void OnStoreConnectionFailed(string jsonFailureDescription) { }

	public override void OnStoreConnectionSucceeded() { }

	[NullableContext(2)]
	private static StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json) { }

	internal void ProcessManagedStoreResponse(List<ProductDefinition> storeProducts) { }

	protected override void Purchase(ProductDefinition productDefinition, string developerPayload) { }

	public virtual void Purchase(ICart cart) { }

	public void SetNativeStore(INativeStore native) { }

}

