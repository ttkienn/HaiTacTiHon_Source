namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class MetricizedGooglePlayStoreService : GooglePlayStoreService
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		[Nullable(0)]
		public MetricizedGooglePlayStoreService <>4__this; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Action<List`1<ProductDescription>> onProductsReceived; //Field offset: 0x20
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Action<GoogleFetchProductException> onFetchProductsFailed; //Field offset: 0x28

		public <>c__DisplayClass2_0() { }

		internal void <FetchProducts>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		[Nullable(0)]
		public MetricizedGooglePlayStoreService <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x18
		[Nullable(0)]
		public Order currentOrder; //Field offset: 0x20
		public Nullable<GooglePlayReplacementMode> desiredReplacementMode; //Field offset: 0x28

		public <>c__DisplayClass3_0() { }

		internal void <Purchase>b__0() { }

	}

	private readonly ITelemetryMetricsService m_TelemetryMetricsService; //Field offset: 0x58

	[Preserve]
	internal MetricizedGooglePlayStoreService(IGoogleBillingClient billingClient, IGooglePlayStoreConnectionService connectionService, IQueryProductDetailsService queryProductDetailsService, IGoogleLastKnownProductService lastKnownProductService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionUseCase finishTransactionUseCase, IGoogleQueryPurchasesUseCase queryPurchasesUseCase, IGooglePlayCheckEntitlementUseCase googleCheckEntitlementUseCase, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(IReadOnlyCollection<ProductDefinition> products, Action<List`1<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__1(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List`1<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	public virtual void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

}

