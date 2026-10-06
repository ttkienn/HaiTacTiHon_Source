namespace UnityEngine.Purchasing.Extension;

public interface IStoreProductsCallback
{

	public void OnProductsFetched(IReadOnlyList<ProductDescription> products) { }

	public void OnProductsFetchFailed(ProductFetchFailureDescription failureDescription) { }

}

