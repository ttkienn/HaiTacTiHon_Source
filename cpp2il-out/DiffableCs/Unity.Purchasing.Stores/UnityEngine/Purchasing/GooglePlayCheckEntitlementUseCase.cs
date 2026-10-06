namespace UnityEngine.Purchasing;

internal class GooglePlayCheckEntitlementUseCase : IGooglePlayCheckEntitlementUseCase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public ProductDefinition product; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <PurchaseToCheckForEntitlement>b__0(IGooglePurchase purchase) { }

	}

	[CompilerGenerated]
	private struct <CheckEntitlement>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ProductDefinition product; //Field offset: 0x28
		public GooglePlayCheckEntitlementUseCase <>4__this; //Field offset: 0x30
		public Action<ProductDefinition, EntitlementStatus> onEntitlementChecked; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<IGooglePurchase>> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; //Field offset: 0x10

	[Preserve]
	internal GooglePlayCheckEntitlementUseCase(IGoogleQueryPurchasesUseCase googleQueryPurchasesUseCase) { }

	[AsyncStateMachine(typeof(<CheckEntitlement>d__2))]
	public override void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked) { }

	private static EntitlementStatus DetermineEntitlementStatus(IGooglePurchase purchase, ProductType type) { }

	private static Func<IGooglePurchase, Boolean> PurchaseToCheckForEntitlement(ProductDefinition product) { }

}

