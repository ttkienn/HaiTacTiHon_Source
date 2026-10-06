namespace UnityEngine.Purchasing;

internal interface IGooglePlayStoreFetchPurchasesService
{

	public void FetchPurchases() { }

	public void FetchPurchases(Action<List`1<Product>> onQueryPurchaseSucceed) { }

	public IGooglePurchase GetGooglePurchase(string purchaseToken) { }

	public void SetProductCache(IProductCache productCache) { }

	public void SetPurchaseFetchCallback(IStorePurchaseFetchCallback fetchCallback) { }

}

