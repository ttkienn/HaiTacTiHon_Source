namespace UnityEngine.Purchasing;

[NullableContext(2)]
public interface IAppleStoreExtendedPurchaseService : IPurchaseServiceExtension
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<String> OnEntitlementRevoked
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<Product> OnPromotionalPurchaseIntercepted
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Obsolete]
	public string appReceipt
	{
		 get { } //Length: 0
	}

	public bool simulateAskToBuy
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnEntitlementRevoked(Action<String> value) { }

	[CompilerGenerated]
	public void add_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	public void ContinuePromotionalPurchases() { }

	public string get_appReceipt() { }

	public bool get_simulateAskToBuy() { }

	public void PresentCodeRedemptionSheet() { }

	[NullableContext(1)]
	[Obsolete]
	public void RefreshAppReceipt(Action<String> successCallback, Action<String> errorCallback) { }

	[CompilerGenerated]
	public void remove_OnEntitlementRevoked(Action<String> value) { }

	[CompilerGenerated]
	public void remove_OnPromotionalPurchaseIntercepted(Action<Product> value) { }

	public void set_simulateAskToBuy(bool value) { }

	[Obsolete]
	public void SetRefreshAppReceipt(bool refreshAppReceipt) { }

}

