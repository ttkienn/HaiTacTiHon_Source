namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IGooglePlayGetGooglePurchaseUseCase
{

	public IGooglePurchase GetGooglePurchase(string purchaseToken) { }

}

