namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePurchasesUpdatedHandler : IGooglePurchasesUpdatedHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		[Nullable(0)]
		public GooglePurchasesUpdatedHandler <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public IGoogleBillingResult billingResult; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal void <HandleExistingPurchasesErrorCase>b__0(IGooglePurchase purchase) { }

	}

	[CompilerGenerated]
	private struct <HandleUserCancelledPurchaseFailure>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePurchasesUpdatedHandler <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public IGoogleBillingResult billingResult; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<IGooglePurchase>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IGoogleLastKnownProductService m_LastKnownProductService; //Field offset: 0x10
	private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; //Field offset: 0x18
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; //Field offset: 0x20
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; //Field offset: 0x28
	[Nullable(2)]
	private IProductCache m_ProductCache; //Field offset: 0x30

	[Preserve]
	internal GooglePurchasesUpdatedHandler(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase) { }

	[CompilerGenerated]
	[NullableContext(0)]
	private bool <HandleUserCancelledPurchaseFailure>b__13_0(IGooglePurchase purchase) { }

	private void ApplyOnPurchases(List<IGooglePurchase> purchases, Action<IGooglePurchase> action) { }

	private void HandleErrorCases(IGoogleBillingResult billingResult, List<IGooglePurchase> purchases) { }

	private void HandleExistingPurchasesErrorCase(List<IGooglePurchase> purchases, IGoogleBillingResult billingResult) { }

	private void HandleNoPurchasesErrorCase(IGoogleBillingResult billingResult) { }

	private void HandlePurchasedProduct(IGooglePurchase googlePurchase) { }

	private void HandleResultOkCases(IGoogleBillingResult result, List<IGooglePurchase> purchases) { }

	public override void HandleUpdatedPurchases(IGoogleBillingResult result, List<IGooglePurchase> purchases) { }

	[AsyncStateMachine(typeof(<HandleUserCancelledPurchaseFailure>d__12))]
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult) { }

	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, List<IGooglePurchase> googlePurchases) { }

	private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase) { }

	private bool IsLastReplacementModeDeferred() { }

	private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase) { }

	private void OnPurchaseCancelled(IGoogleBillingResult billingResult) { }

	private void OnPurchaseCancelled(IGooglePurchase googlePurchase) { }

	private void OnPurchaseFailedForUnknownReason(IGooglePurchase googlePurchase, string debugMessage) { }

	private void OnPurchaseOk(IGooglePurchase googlePurchase) { }

	[NullableContext(2)]
	public override void SetProductCache(IProductCache productCache) { }

	public void SubscribeToPurchasesUpdatedEvent(IGooglePurchasesUpdatedListener purchasesUpdatedListener) { }

}

