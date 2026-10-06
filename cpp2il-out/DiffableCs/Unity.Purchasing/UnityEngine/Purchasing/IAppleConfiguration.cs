namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public interface IAppleConfiguration : IStoreConfiguration
{

	public string appReceipt
	{
		 get { } //Length: 0
	}

	public bool canMakePayments
	{
		 get { } //Length: 0
	}

	public string get_appReceipt() { }

	public bool get_canMakePayments() { }

	public void SetApplePromotionalPurchaseInterceptorCallback(Action<Product> callback) { }

	public void SetEntitlementsRevokedListener(Action<List`1<Product>> callback) { }

}

