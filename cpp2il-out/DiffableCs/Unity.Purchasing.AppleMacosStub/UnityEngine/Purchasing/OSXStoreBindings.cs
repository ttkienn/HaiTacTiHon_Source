namespace UnityEngine.Purchasing;

internal class OSXStoreBindings : INativeAppleStore, INativeStore
{

	public override bool canMakePayments
	{
		 get { } //Length: 62
	}

	public OSXStoreBindings() { }

	public override void AddTransactionObserver() { }

	public override string AppReceipt() { }

	public override bool CheckEntitlement(string productJSON) { }

	public override void Connect() { }

	public override void ContinuePromotionalPurchases() { }

	public override void DeallocateMemory(IntPtr pointer) { }

	public override void FetchExistingPurchases() { }

	public override void FetchProducts(string json) { }

	public void FetchPurchases(string json) { }

	public override void FetchStorePromotionOrder() { }

	public override void FetchStorePromotionVisibility(string productId) { }

	public override void FinishTransaction(string productJSON, string transactionID) { }

	public override bool get_canMakePayments() { }

	public override void InterceptPromotionalPurchases() { }

	public override void PresentCodeRedemptionSheet() { }

	public void Purchase(string productJson, string optionsJson, StorefrontChangeCallback callback) { }

	public override void Purchase(string productJSON, string developerPayload) { }

	public override void RefreshAppReceipt() { }

	public override void RestoreTransactions() { }

	public void SetAppAccountToken(string token) { }

	public override void SetStorePromotionOrder(string json) { }

	public override void SetStorePromotionVisibility(string productId, string visibility) { }

	public override void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

}

