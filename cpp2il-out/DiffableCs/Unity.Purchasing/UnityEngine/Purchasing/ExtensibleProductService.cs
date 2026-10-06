namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public abstract class ExtensibleProductService : IProductService
{
	private IProductService m_BaseInternalProductService; //Field offset: 0x10

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

	[Nullable(2)]
	public override IAppleStoreExtendedProductService Apple
	{
		[NullableContext(2)]
		 get { } //Length: 70
	}

	protected ExtensibleProductService(IProductService baseProductService) { }

	public override void add_OnProductsFetched(Action<List`1<Product>> value) { }

	public override void add_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	public override void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy retryPolicy = null) { }

	public override void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions) { }

	[NullableContext(2)]
	public override IAppleStoreExtendedProductService get_Apple() { }

	public override Product GetProductById(string productId) { }

	public override ReadOnlyObservableCollection<Product> GetProducts() { }

	public override void remove_OnProductsFetched(Action<List`1<Product>> value) { }

	public override void remove_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

}

