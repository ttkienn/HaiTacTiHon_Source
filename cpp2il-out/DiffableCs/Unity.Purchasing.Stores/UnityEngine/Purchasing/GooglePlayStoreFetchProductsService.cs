namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreFetchProductsService : IGooglePlayStoreFetchProductsService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		[Nullable(0)]
		public Product purchaseProduct; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <MakePurchasesIntoProducts>b__0(ProductDescription product) { }

	}

	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x10
	[Nullable(2)]
	private IStoreProductsCallback m_ProductsCallback; //Field offset: 0x18

	[Preserve]
	internal GooglePlayStoreFetchProductsService(IGooglePlayStoreService googlePlayStoreService) { }

	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	[Obsolete]
	private static List<ProductDescription> MakePurchasesIntoProducts(List<ProductDescription> retrievedProducts, IEnumerable<Product> purchaseProducts) { }

	private void OnFetchProductsFailed(GoogleFetchProductException exception) { }

	private void OnProductsFetched(List<ProductDescription> retrievedProducts) { }

	public override void SetProductsCallback(IStoreProductsCallback productsCallback) { }

}

