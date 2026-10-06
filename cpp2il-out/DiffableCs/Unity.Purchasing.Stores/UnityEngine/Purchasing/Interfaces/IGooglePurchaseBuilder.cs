namespace UnityEngine.Purchasing.Interfaces;

internal interface IGooglePurchaseBuilder
{

	public IEnumerable<IGooglePurchase> BuildPurchases(IEnumerable<AndroidJavaObject> purchases) { }

}

