namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public interface IGooglePlayConfiguration : IStoreConfiguration
{

	public void SetDeferredProrationUpgradeDowngradeSubscriptionListener(Action<Product> action) { }

	public void SetDeferredPurchaseListener(Action<Product> action) { }

	public void SetFetchPurchasesAtInitialize(bool enable) { }

	public void SetFetchPurchasesExcludeDeferred(bool exclude) { }

	public void SetObfuscatedAccountId(string accountId) { }

	public void SetObfuscatedProfileId(string profileId) { }

	public void SetQueryProductDetailsFailedListener(Action<Int32> action) { }

	public void SetServiceDisconnectAtInitializeListener(Action action) { }

}

