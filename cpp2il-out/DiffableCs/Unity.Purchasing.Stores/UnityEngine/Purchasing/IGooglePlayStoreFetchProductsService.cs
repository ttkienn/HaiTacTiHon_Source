namespace UnityEngine.Purchasing;

internal interface IGooglePlayStoreFetchProductsService
{

	public void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public void SetProductsCallback(IStoreProductsCallback productsCallback) { }

}

