namespace UnityEngine.Purchasing;

internal interface IGoogleCachedQueryProductDetailsService
{

	public void AddCachedQueriedProductDetails(IEnumerable<AndroidJavaObject> queriedProducts) { }

	public bool Contains(ProductDefinition products) { }

	public IEnumerable<AndroidJavaObject> GetCachedQueriedProductDetails(IEnumerable<ProductDefinition> products) { }

	public IEnumerable<AndroidJavaObject> GetCachedQueriedProducts() { }

}

