namespace UnityEngine.Purchasing;

internal class AppleExtensions : IAppleExtensions, IStoreExtension
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Action errorCallback; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal void <FetchStorePromotionVisibility>g__ErrorCallbackWrapper|0(string _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Action errorCallback; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal void <FetchStorePromotionOrder>g__ErrorCallbackWrapper|0(string _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Action<Product> callback; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		[NullableContext(1)]
		internal void <RegisterPurchaseDeferredListener>b__0(DeferredOrder deferredOrder) { }

	}


	public override bool simulateAskToBuy
	{
		 get { } //Length: 104
		 set { } //Length: 117
	}

	public AppleExtensions() { }

	public override void ContinuePromotionalPurchases() { }

	public override void FetchStorePromotionOrder(Action<List`1<Product>> successCallback, Action errorCallback) { }

	public override void FetchStorePromotionVisibility(Product product, Action<String, AppleStorePromotionVisibility> successCallback, Action errorCallback) { }

	public override bool get_simulateAskToBuy() { }

	public override Dictionary<String, String> GetIntroductoryPriceDictionary() { }

	public override Dictionary<String, String> GetProductDetails() { }

	public override string GetTransactionReceiptForProduct(Product _) { }

	public override void PresentCodeRedemptionSheet() { }

	public override void RefreshAppReceipt(Action<String> successCallback, Action<String> errorCallback) { }

	public override void RegisterPurchaseDeferredListener(Action<Product> callback) { }

	public override void RestoreTransactions(Action<Boolean, String> callback) { }

	public override void set_simulateAskToBuy(bool value) { }

	public override void SetApplicationUsername(string applicationUsername) { }

	public override void SetStorePromotionOrder(List<Product> products) { }

	public override void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible) { }

}

