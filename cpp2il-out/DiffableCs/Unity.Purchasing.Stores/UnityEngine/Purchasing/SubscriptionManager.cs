namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class SubscriptionManager : SubscriptionInfoHelper
{

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public SubscriptionManager(Product product, string intro_json) { }

	public SubscriptionManager(string receipt, string id, string intro_json) { }

	public SubscriptionInfo getSubscriptionInfo() { }

	public static void UpdateSubscription(Product newProduct, Product oldProduct, string developerPayload, Action<Product, String> appleStore, Action<String, String> googleStore) { }

	public static void UpdateSubscriptionInAppleStore(Product newProduct, string developerPayload, Action<Product, String> appleStoreUpdateCallback) { }

	public static void UpdateSubscriptionInGooglePlayStore(Product oldProduct, Product newProduct, Action<String, String> googlePlayUpdateCallback) { }

}

