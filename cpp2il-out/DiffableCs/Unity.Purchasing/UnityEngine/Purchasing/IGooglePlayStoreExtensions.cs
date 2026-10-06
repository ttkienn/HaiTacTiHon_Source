namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public interface IGooglePlayStoreExtensions : IStoreExtension
{

	[Obsolete("No longer functional. This calls launchPriceChangeConfirmationFlow which was removed from Google Play Billing Library 6.0.0")]
	public void ConfirmSubscriptionPriceChange(string productId, Action<Boolean> callback) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public string GetObfuscatedAccountId(Product product) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public string GetObfuscatedProfileId(Product product) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public GooglePurchaseState GetPurchaseState(Product product) { }

	public bool IsPurchasedProductDeferred(Product product) { }

	public void RestoreTransactions(Action<Boolean, String> callback) { }

	public void UpgradeDowngradeSubscription(string oldSku, string newSku) { }

	public void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode) { }

	public void UpgradeDowngradeSubscription(string oldSku, string newSku, GooglePlayProrationMode desiredProrationMode) { }

}

