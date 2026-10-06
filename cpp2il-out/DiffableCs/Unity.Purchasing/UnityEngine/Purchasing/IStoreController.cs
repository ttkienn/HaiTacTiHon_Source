namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public interface IStoreController
{

	public ProductCollection products
	{
		 get { } //Length: 0
	}

	public void ConfirmPendingPurchase(Product product) { }

	public void FetchAdditionalProducts(HashSet<ProductDefinition> additionalProducts, Action successCallback, Action<InitializationFailureReason, String> failCallback) { }

	public ProductCollection get_products() { }

	public void InitiatePurchase(Product product, string payload) { }

	public void InitiatePurchase(string productId, string payload) { }

	public void InitiatePurchase(Product product) { }

	public void InitiatePurchase(string productId) { }

}

