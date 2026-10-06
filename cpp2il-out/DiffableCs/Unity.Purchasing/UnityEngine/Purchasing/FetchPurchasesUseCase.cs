namespace UnityEngine.Purchasing;

internal class FetchPurchasesUseCase : IFetchPurchasesUseCase, IStorePurchaseFetchCallback
{
	private readonly IStore m_Store; //Field offset: 0x10
	[CompilerGenerated]
	private Action<Orders> FetchSuccessAction; //Field offset: 0x18
	[CompilerGenerated]
	private Action<PurchasesFetchFailureDescription> FetchFailureAction; //Field offset: 0x20

	private event Action<PurchasesFetchFailureDescription> FetchFailureAction
	{
		[CompilerGenerated]
		private add { } //Length: 172
		[CompilerGenerated]
		private remove { } //Length: 172
	}

	private event Action<Orders> FetchSuccessAction
	{
		[CompilerGenerated]
		private add { } //Length: 172
		[CompilerGenerated]
		private remove { } //Length: 172
	}

	[Preserve]
	internal FetchPurchasesUseCase(IStore storeResponsible) { }

	[CompilerGenerated]
	private void add_FetchFailureAction(Action<PurchasesFetchFailureDescription> value) { }

	[CompilerGenerated]
	private void add_FetchSuccessAction(Action<Orders> value) { }

	public override void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction) { }

	public override void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders) { }

	public override void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason) { }

	[CompilerGenerated]
	private void remove_FetchFailureAction(Action<PurchasesFetchFailureDescription> value) { }

	[CompilerGenerated]
	private void remove_FetchSuccessAction(Action<Orders> value) { }

}

