namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public interface IAppleExtensions : IStoreExtension
{

	public bool simulateAskToBuy
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void ContinuePromotionalPurchases() { }

	public void FetchStorePromotionOrder(Action<List`1<Product>> successCallback, Action errorCallback) { }

	public void FetchStorePromotionVisibility(Product product, Action<String, AppleStorePromotionVisibility> successCallback, Action errorCallback) { }

	public bool get_simulateAskToBuy() { }

	public Dictionary<String, String> GetIntroductoryPriceDictionary() { }

	public Dictionary<String, String> GetProductDetails() { }

	public string GetTransactionReceiptForProduct(Product product) { }

	public void PresentCodeRedemptionSheet() { }

	public void RefreshAppReceipt(Action<String> successCallback, Action<String> errorCallback) { }

	public void RegisterPurchaseDeferredListener(Action<Product> callback) { }

	public void RestoreTransactions(Action<Boolean, String> callback) { }

	public void set_simulateAskToBuy(bool value) { }

	public void SetApplicationUsername(string applicationUsername) { }

	public void SetStorePromotionOrder(List<Product> products) { }

	public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible) { }

}

