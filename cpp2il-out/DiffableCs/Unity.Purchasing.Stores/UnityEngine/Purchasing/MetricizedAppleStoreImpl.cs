namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class MetricizedAppleStoreImpl : AppleStoreImpl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		[Nullable(0)]
		public MetricizedAppleStoreImpl <>4__this; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <FetchProducts>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		[Nullable(0)]
		public MetricizedAppleStoreImpl <>4__this; //Field offset: 0x10
		[Nullable(0)]
		public ICart cart; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <Purchase>b__0() { }

	}

	private readonly ITelemetryMetricsService m_TelemetryMetricsService; //Field offset: 0x130

	[Preserve]
	internal MetricizedAppleStoreImpl(ICartValidator cartValidator, IAppleFetchProductsService fetchProductsService, ITransactionLog transactionLog, IUtil util, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(IReadOnlyCollection<ProductDefinition> products) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__1(ICart cart) { }

	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public virtual void Purchase(ICart cart) { }

}

