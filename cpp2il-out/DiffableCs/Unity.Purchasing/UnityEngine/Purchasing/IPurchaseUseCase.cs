namespace UnityEngine.Purchasing;

internal interface IPurchaseUseCase
{

	public event Action<DeferredOrder> OnPurchaseDefer
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<FailedOrder> OnPurchaseFail
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action<PendingOrder> OnPurchaseSuccess
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnPurchaseDefer(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public void add_OnPurchaseFail(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public void add_OnPurchaseSuccess(Action<PendingOrder> value) { }

	public void Purchase(ICart cart) { }

	[CompilerGenerated]
	public void remove_OnPurchaseDefer(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseFail(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseSuccess(Action<PendingOrder> value) { }

}

