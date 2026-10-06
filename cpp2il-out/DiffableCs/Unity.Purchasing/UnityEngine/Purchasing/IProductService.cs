namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IProductService
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public event Action<List`1<Product>> OnProductsFetched
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<ProductFetchFailed> OnProductsFetchFailed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(2)]
	public IAppleStoreExtendedProductService Apple
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnProductsFetched(Action<List`1<Product>> value) { }

	[CompilerGenerated]
	public void add_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

	public void FetchProducts(List<ProductDefinition> productDefinitions, IRetryPolicy retryPolicy = null) { }

	public void FetchProductsWithNoRetries(List<ProductDefinition> productDefinitions) { }

	[NullableContext(2)]
	public IAppleStoreExtendedProductService get_Apple() { }

	public Product GetProductById(string productId) { }

	public ReadOnlyObservableCollection<Product> GetProducts() { }

	[CompilerGenerated]
	public void remove_OnProductsFetched(Action<List`1<Product>> value) { }

	[CompilerGenerated]
	public void remove_OnProductsFetchFailed(Action<ProductFetchFailed> value) { }

}

