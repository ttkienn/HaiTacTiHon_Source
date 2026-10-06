namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayStoreService : IGooglePlayStoreService
{
	[CompilerGenerated]
	private struct <FetchProducts>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePlayStoreService <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<List`1<ProductDescription>> onProductsReceived; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Action<GoogleFetchProductException> onFetchProductsFailed; //Field offset: 0x40
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<ProductDescription>> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchPurchases>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePlayStoreService <>4__this; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<List`1<IGooglePurchase>> onQueryPurchaseSucceed; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 2}])]
		public Action<String> onQueryPurchaseFailed; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FinishTransaction>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePlayStoreService <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x28
		[Nullable(0)]
		public string purchaseToken; //Field offset: 0x30
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryFetchPurchases>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePlayStoreService <>4__this; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<List`1<IGooglePurchase>> onQueryPurchaseSucceed; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<IGooglePurchase>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IQueryProductDetailsService m_QueryProductDetailsService; //Field offset: 0x10
	private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService; //Field offset: 0x18
	private readonly IGooglePurchaseService m_GooglePurchaseService; //Field offset: 0x20
	private readonly IGoogleFinishTransactionUseCase m_GoogleFinishTransactionUseCase; //Field offset: 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0x30
	private readonly IGoogleQueryPurchasesUseCase m_GoogleQueryPurchasesUseCase; //Field offset: 0x38
	private readonly IGooglePlayCheckEntitlementUseCase m_GoogleCheckEntitlementUseCase; //Field offset: 0x40
	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x48
	private readonly IGooglePlayStoreConnectionService m_GooglePlayStoreConnectionService; //Field offset: 0x50

	internal GooglePlayStoreService(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics) { }

	public override void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked) { }

	[AsyncStateMachine(typeof(<FetchProducts>d__10))]
	public override void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List`1<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	[AsyncStateMachine(typeof(<FetchPurchases>d__14))]
	public override void FetchPurchases(Action<List`1<IGooglePurchase>> onQueryPurchaseSucceed, Action<String> onQueryPurchaseFailed) { }

	[AsyncStateMachine(typeof(<FinishTransaction>d__13))]
	public override Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

	public override bool IsConnectionReady() { }

	public override void Purchase(ProductDefinition product) { }

	public override void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	public override void SetObfuscatedAccountId(string obfuscatedAccountId) { }

	public override void SetObfuscatedProfileId(string obfuscatedProfileId) { }

	[AsyncStateMachine(typeof(<TryFetchPurchases>d__15))]
	private Task TryFetchPurchases(Action<List`1<IGooglePurchase>> onQueryPurchaseSucceed) { }

}

