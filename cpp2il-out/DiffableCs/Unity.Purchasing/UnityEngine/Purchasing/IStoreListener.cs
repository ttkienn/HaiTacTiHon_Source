namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public interface IStoreListener
{

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions) { }

	[Obsolete]
	public void OnInitializeFailed(InitializationFailureReason error) { }

	public void OnInitializeFailed(InitializationFailureReason error, string message = null) { }

	[Obsolete("Use IDetailedStoreListener.OnPurchaseFailed for more detailed callback.", False)]
	public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason) { }

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args) { }

}

