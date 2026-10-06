namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(2)]
public class StoreController : IStoreService, IProductService, IPurchaseService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		[Nullable(0)]
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass69_0() { }

		[NullableContext(0)]
		internal bool <PurchaseProduct>b__0(Product product) { }

	}

	[Nullable(1)]
	private IStoreService m_StoreService; //Field offset: 0x10
	[Nullable(1)]
	private IProductService m_ProductService; //Field offset: 0x18
	[Nullable(1)]
	private IPurchaseService m_PurchaseService; //Field offset: 0x20

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Entitlement> OnCheckEntitlement
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public override event Action<List`1<Product>> OnProductsFetched
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<ProductFetchFailed> OnProductsFetchFailed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Order> OnPurchaseConfirmed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<DeferredOrder> OnPurchaseDeferred
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<FailedOrder> OnPurchaseFailed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<PendingOrder> OnPurchasePending
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Orders> OnPurchasesFetched
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<StoreConnectionFailureDescription> OnStoreDisconnected
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	public IAppleStoreExtendedProductService AppleStoreExtendedProductService
	{
		 get { } //Length: 70
	}

	public IAppleStoreExtendedPurchaseService AppleStoreExtendedPurchaseService
	{
		 get { } //Length: 70
	}

	public IAppleStoreExtendedService AppleStoreExtendedService
	{
		 get { } //Length: 70
	}

	public IGooglePlayStoreExtendedPurchaseService GooglePlayStoreExtendedPurchaseService
	{
		 get { } //Length: 73
	}

	public IGooglePlayStoreExtendedService GooglePlayStoreExtendedService
	{
		 get { } //Length: 73
	}

	private override IAppleStoreExtendedProductService UnityEngine.Purchasing.IProductService.Apple
	{
		private get { } //Length: 70
	}

	private override IAppleStoreExtendedPurchaseService UnityEngine.Purchasing.IPurchaseService.Apple
	{
		private get { } //Length: 70
	}

	private override IGooglePlayStoreExtendedPurchaseService UnityEngine.Purchasing.IPurchaseService.Google
	{
		private get { } //Length: 73
	}

	private override IAppleStoreExtendedService UnityEngine.Purchasing.IStoreService.Apple
	{
		private get { } //Length: 70
	}

	private override IGooglePlayStoreExtendedService UnityEngine.Purchasing.IStoreService.Google
	{
		private get { } //Length: 73
	}

	public StoreController(string storeName = null) { }

	public override void add_OnCheckEntitlement(Action<Entitlement> value) { }

	public override void add_OnProductsFetched(Action<List`1<Product>> value) { }

	public override void add_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	public override void add_OnPurchaseConfirmed(Action<Order> value) { }

	public override void add_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	public override void add_OnPurchaseFailed(Action<FailedOrder> value) { }

	public override void add_OnPurchasePending(Action<PendingOrder> value) { }

	public override void add_OnPurchasesFetched(Action<Orders> value) { }

	public override void add_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	public override void add_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	[NullableContext(1)]
	public override void CheckEntitlement(Product product) { }

	[NullableContext(1)]
	public override void ConfirmPurchase(PendingOrder order) { }

	[NullableContext(1)]
	public override Task Connect() { }

	[NullableContext(1)]
	public override void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy retryPolicy = null) { }

	[NullableContext(1)]
	public override void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions) { }

	public override void FetchPurchases() { }

	public IAppleStoreExtendedProductService get_AppleStoreExtendedProductService() { }

	public IAppleStoreExtendedPurchaseService get_AppleStoreExtendedPurchaseService() { }

	public IAppleStoreExtendedService get_AppleStoreExtendedService() { }

	public IGooglePlayStoreExtendedPurchaseService get_GooglePlayStoreExtendedPurchaseService() { }

	public IGooglePlayStoreExtendedService get_GooglePlayStoreExtendedService() { }

	[NullableContext(1)]
	public override Product GetProductById(string productId) { }

	[NullableContext(1)]
	public override ReadOnlyObservableCollection<Product> GetProducts() { }

	[NullableContext(1)]
	public override ReadOnlyObservableCollection<Order> GetPurchases() { }

	public override void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess) { }

	[NullableContext(1)]
	public override void Purchase(ICart cart) { }

	[NullableContext(1)]
	public override void PurchaseProduct(Product product) { }

	public void PurchaseProduct(string productId) { }

	public override void remove_OnCheckEntitlement(Action<Entitlement> value) { }

	public override void remove_OnProductsFetched(Action<List`1<Product>> value) { }

	public override void remove_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	public override void remove_OnPurchaseConfirmed(Action<Order> value) { }

	public override void remove_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	public override void remove_OnPurchaseFailed(Action<FailedOrder> value) { }

	public override void remove_OnPurchasePending(Action<PendingOrder> value) { }

	public override void remove_OnPurchasesFetched(Action<Orders> value) { }

	public override void remove_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	public override void remove_OnStoreDisconnected(Action<StoreConnectionFailureDescription> value) { }

	public override void RestoreTransactions(Action<Boolean, String> callback) { }

	public override void SetStoreReconnectionRetryPolicyOnDisconnection(IRetryPolicy retryPolicy) { }

	[NullableContext(1)]
	internal void SetTestInstances(IStoreService storeService, IProductService productService, IPurchaseService purchaseService) { }

	private override IAppleStoreExtendedProductService UnityEngine.Purchasing.IProductService.get_Apple() { }

	private override IAppleStoreExtendedPurchaseService UnityEngine.Purchasing.IPurchaseService.get_Apple() { }

	private override IGooglePlayStoreExtendedPurchaseService UnityEngine.Purchasing.IPurchaseService.get_Google() { }

	private override IAppleStoreExtendedService UnityEngine.Purchasing.IStoreService.get_Apple() { }

	private override IGooglePlayStoreExtendedService UnityEngine.Purchasing.IStoreService.get_Google() { }

}

