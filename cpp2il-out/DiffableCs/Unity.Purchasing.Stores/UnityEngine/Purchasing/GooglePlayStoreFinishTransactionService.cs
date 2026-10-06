namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreFinishTransactionService : IGooglePlayStoreFinishTransactionService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(0)]
		public GooglePlayStoreFinishTransactionService <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal void <FinishTransaction>b__0(IGoogleBillingResult billingResult, IGooglePurchase googlePurchase) { }

	}

	[CompilerGenerated]
	private struct <FinishTransaction>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePlayStoreFinishTransactionService <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x30
		[Nullable(0)]
		public string purchaseToken; //Field offset: 0x38
		[Nullable(0)]
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int k_MaxRetryAttempts = 5; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2}])]
	private readonly HashSet<String> m_ProcessedPurchaseToken; //Field offset: 0x10
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x18
	[Nullable(2)]
	private IProductCache m_ProductCache; //Field offset: 0x20
	[Nullable(2)]
	private IStorePurchaseConfirmCallback m_ConfirmCallback; //Field offset: 0x28
	private int m_RetryCount; //Field offset: 0x30

	[Preserve]
	internal GooglePlayStoreFinishTransactionService(IGooglePlayStoreService googlePlayStoreService) { }

	private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase) { }

	[AsyncStateMachine(typeof(<FinishTransaction>d__9))]
	public override void FinishTransaction(ProductDefinition product, string purchaseToken) { }

	private void HandleFinishTransaction(ProductDefinition product, IGoogleBillingResult billingResult, IGooglePurchase purchase) { }

	private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult) { }

	private void SendTransactionFailedCallback(PurchaseFailureDescription purchaseFailureDescription, string purchaseToken) { }

	public override void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	[NullableContext(2)]
	public override void SetProductCache(IProductCache productCache) { }

}

