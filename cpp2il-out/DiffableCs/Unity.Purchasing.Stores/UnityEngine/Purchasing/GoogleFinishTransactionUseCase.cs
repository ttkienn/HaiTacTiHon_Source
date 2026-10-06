namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GoogleFinishTransactionUseCase : IGoogleFinishTransactionUseCase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished; //Field offset: 0x10
		[Nullable(0)]
		public IGooglePurchase purchase; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		[NullableContext(0)]
		internal void <FinishTransactionForPurchase>b__0(IGoogleBillingResult result) { }

		[NullableContext(0)]
		internal void <FinishTransactionForPurchase>b__1(IGoogleBillingResult result) { }

	}

	[CompilerGenerated]
	private struct <FinishTransaction>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GoogleFinishTransactionUseCase <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public string purchaseToken; //Field offset: 0x28
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		private TaskAwaiter<IGooglePurchase> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; //Field offset: 0x18

	[Preserve]
	internal GoogleFinishTransactionUseCase(IGoogleBillingClient billingClient, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase) { }

	[AsyncStateMachine(typeof(<FinishTransaction>d__3))]
	public override Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

	private void FinishTransactionForPurchase(IGooglePurchase purchase, ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

}

