namespace UnityEngine.Purchasing.Interfaces;

internal interface IGooglePurchasesUpdatedListener
{

	public event Action<IGoogleBillingResult, List`1<IGooglePurchase>> OnPurchaseUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPurchaseUpdated(Action<IGoogleBillingResult, List`1<IGooglePurchase>> value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseUpdated(Action<IGoogleBillingResult, List`1<IGooglePurchase>> value) { }

}

