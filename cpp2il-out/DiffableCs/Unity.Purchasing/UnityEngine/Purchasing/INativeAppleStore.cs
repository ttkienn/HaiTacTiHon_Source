namespace UnityEngine.Purchasing;

internal interface INativeAppleStore : INativeStore
{

	public bool canMakePayments
	{
		 get { } //Length: 0
	}

	public void AddTransactionObserver() { }

	public string AppReceipt() { }

	public void ContinuePromotionalPurchases() { }

	public void DeallocateMemory(IntPtr pointer) { }

	public void FetchStorePromotionOrder() { }

	public void FetchStorePromotionVisibility(string productId) { }

	public bool get_canMakePayments() { }

	public void InterceptPromotionalPurchases() { }

	public void PresentCodeRedemptionSheet() { }

	public void RefreshAppReceipt() { }

	public void RestoreTransactions() { }

	public void SetStorePromotionOrder(string json) { }

	public void SetStorePromotionVisibility(string productId, string visibility) { }

	public void SetUnityPurchasingCallback(UnityPurchasingCallback asyncCallback) { }

}

