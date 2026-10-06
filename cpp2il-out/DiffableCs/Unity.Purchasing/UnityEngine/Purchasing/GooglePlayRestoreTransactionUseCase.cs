namespace UnityEngine.Purchasing;

internal class GooglePlayRestoreTransactionUseCase : IRestoreTransactionsUseCase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		public Action<Boolean, String> callback; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		[NullableContext(1)]
		internal void <RestoreTransactions>b__0(Orders _) { }

		[NullableContext(1)]
		internal void <RestoreTransactions>b__1(PurchasesFetchFailureDescription desc) { }

	}

	[Nullable(1)]
	private readonly IFetchPurchasesUseCase m_FetchPurchasesUseCase; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	public GooglePlayRestoreTransactionUseCase(IFetchPurchasesUseCase fetchPurchasesUseCase) { }

	[NullableContext(2)]
	public override void RestoreTransactions(Action<Boolean, String> callback) { }

}

