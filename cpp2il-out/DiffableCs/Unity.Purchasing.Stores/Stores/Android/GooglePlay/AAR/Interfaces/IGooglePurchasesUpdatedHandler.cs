namespace Stores.Android.GooglePlay.AAR.Interfaces;

internal interface IGooglePurchasesUpdatedHandler
{

	public void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases) { }

	public void SetProductCache(IProductCache productCache) { }

}

