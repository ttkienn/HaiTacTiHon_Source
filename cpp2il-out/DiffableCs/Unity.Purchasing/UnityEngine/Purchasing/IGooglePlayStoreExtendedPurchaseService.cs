namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IGooglePlayStoreExtendedPurchaseService : IPurchaseServiceExtension
{

	public event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

	public string GetObfuscatedAccountId(Order order) { }

	public string GetObfuscatedProfileId(Order order) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public Nullable<GooglePurchaseState> GetPurchaseState(Order order) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public bool IsOrderDeferred(Order order) { }

	[CompilerGenerated]
	public void remove_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayProrationMode desiredProrationMode) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public void UpgradeDowngradeSubscription(Product oldProduct, Product newProduct, GooglePlayReplacementMode desiredReplacementMode) { }

	public void UpgradeDowngradeSubscription(Order currentOrder, Product newProduct, GooglePlayReplacementMode desiredReplacementMode) { }

}

