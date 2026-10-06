namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ProductService : IProductService
{
	private static readonly IRetryPolicy k_DefaultRetryPolicy; //Field offset: 0x0
	private readonly IFetchProductsUseCase m_FetchProductsUseCase; //Field offset: 0x10
	private readonly IStoreWrapper m_StoreWrapper; //Field offset: 0x18
	private readonly IProductCache m_ProductCache; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Action<List`1<Product>> OnProductsFetched; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<ProductFetchFailed> OnProductsFetchFailed; //Field offset: 0x30

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public override event Action<List`1<Product>> OnProductsFetched
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<ProductFetchFailed> OnProductsFetchFailed
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	[Nullable(2)]
	public override IAppleStoreExtendedProductService Apple
	{
		[NullableContext(2)]
		 get { } //Length: 57
	}

	private static ProductService() { }

	internal ProductService(IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper) { }

	[CompilerGenerated]
	public override void add_OnProductsFetched(Action<List`1<Product>> value) { }

	[CompilerGenerated]
	public override void add_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	private void CheckStoreConnectionState() { }

	public override void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy retryPolicy) { }

	public override void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions) { }

	[NullableContext(2)]
	public override IAppleStoreExtendedProductService get_Apple() { }

	public override Product GetProductById(string productId) { }

	public override ReadOnlyObservableCollection<Product> GetProducts() { }

	private void HandleProductsFetched(List<Product> fetchedProducts) { }

	private void HandleProductsFetchFailed(List<ProductDefinition> fetchedProducts, string reason) { }

	[CompilerGenerated]
	public override void remove_OnProductsFetched(Action<List`1<Product>> value) { }

	[CompilerGenerated]
	public override void remove_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

}

