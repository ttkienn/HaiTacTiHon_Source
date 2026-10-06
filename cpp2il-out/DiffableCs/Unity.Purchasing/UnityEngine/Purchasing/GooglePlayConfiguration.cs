namespace UnityEngine.Purchasing;

internal class GooglePlayConfiguration : IGooglePlayConfiguration, IStoreConfiguration
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Action action; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		[NullableContext(1)]
		internal void <SetServiceDisconnectAtInitializeListener>b__0(StoreConnectionFailureDescription _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Action<Int32> action; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		[NullableContext(1)]
		internal void <SetQueryProductDetailsFailedListener>b__0(ProductFetchFailed _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action<Product> action; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		[NullableContext(1)]
		internal void <SetDeferredPurchaseListener>b__0(DeferredOrder order) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Action<Product> action; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		[NullableContext(1)]
		internal void <SetDeferredProrationUpgradeDowngradeSubscriptionListener>b__0(DeferredPaymentUntilRenewalDateOrder order) { }

	}


	public GooglePlayConfiguration() { }

	public override void SetDeferredProrationUpgradeDowngradeSubscriptionListener(Action<Product> action) { }

	public override void SetDeferredPurchaseListener(Action<Product> action) { }

	public override void SetFetchPurchasesAtInitialize(bool enable) { }

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public override void SetFetchPurchasesExcludeDeferred(bool exclude) { }

	public override void SetObfuscatedAccountId(string accountId) { }

	public override void SetObfuscatedProfileId(string profileId) { }

	public override void SetQueryProductDetailsFailedListener(Action<Int32> action) { }

	public override void SetServiceDisconnectAtInitializeListener(Action action) { }

}

