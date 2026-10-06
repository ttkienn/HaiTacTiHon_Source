namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IAppleStoreCallbacks
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<Product> OnPromotionalPurchaseIntercepted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool simulateAskToBuy
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	public void ClearTransactionLog() { }

	public bool get_simulateAskToBuy() { }

	[CompilerGenerated]
	public void remove_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	public void set_simulateAskToBuy(bool value) { }

	public void SetAppAccountToken(Guid token) { }

	public void SetFetchStorePromotionOrderCallbacks(Action<List`1<Product>> successCallback, Action<String> errorCallback) { }

	public void SetFetchStorePromotionVisibilityCallbacks(Action<String, AppleStorePromotionVisibility> successCallback, Action<String> errorCallback) { }

	public void SetRefreshAppReceipt(bool refreshAppReceipt) { }

	public void SetRefreshAppReceiptCallbacks(Action<String> successCallback, Action<String> errorCallback) { }

	[NullableContext(2)]
	public void SetRestoreTransactionsCallback(Action<Boolean, String> successCallback) { }

}

