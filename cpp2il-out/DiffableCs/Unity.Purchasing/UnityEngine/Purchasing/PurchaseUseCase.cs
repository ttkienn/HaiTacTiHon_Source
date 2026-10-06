namespace UnityEngine.Purchasing;

internal class PurchaseUseCase : IPurchaseUseCase, IStorePurchaseCallback
{
	[CompilerGenerated]
	private readonly IStore <m_Store>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Action<PendingOrder> OnPurchaseSuccess; //Field offset: 0x18
	[CompilerGenerated]
	private Action<FailedOrder> OnPurchaseFail; //Field offset: 0x20
	[CompilerGenerated]
	private Action<DeferredOrder> OnPurchaseDefer; //Field offset: 0x28

	public override event Action<DeferredOrder> OnPurchaseDefer
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public override event Action<FailedOrder> OnPurchaseFail
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public override event Action<PendingOrder> OnPurchaseSuccess
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	protected IStore m_Store
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal PurchaseUseCase(IStore storeResponsible) { }

	[CompilerGenerated]
	public override void add_OnPurchaseDefer(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public override void add_OnPurchaseFail(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public override void add_OnPurchaseSuccess(Action<PendingOrder> value) { }

	[CompilerGenerated]
	protected IStore get_m_Store() { }

	public override void OnPurchaseDeferred(DeferredOrder deferredOrder) { }

	public override void OnPurchaseFailed(FailedOrder failedOrder) { }

	public override void OnPurchaseSucceeded(PendingOrder order) { }

	public override void Purchase(ICart cart) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseDefer(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseFail(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public override void remove_OnPurchaseSuccess(Action<PendingOrder> value) { }

}

