namespace UnityEngine.Purchasing;

internal class MetricizedJsonStore : JsonStore
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public MetricizedJsonStore <>4__this; //Field offset: 0x10
		public IReadOnlyCollection<ProductDefinition> products; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <FetchProducts>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public MetricizedJsonStore <>4__this; //Field offset: 0x10
		public ICart cart; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <Purchase>b__0() { }

	}

	private readonly ITelemetryMetricsService m_TelemetryMetricsService; //Field offset: 0x98

	internal MetricizedJsonStore(ICartValidator cartValidator, ILogger logger, string storeName, ITelemetryMetricsService telemetryMetricsService) { }

	[CompilerGenerated]
	[DebuggerHidden]
	[NullableContext(1)]
	private void <>n__0(IReadOnlyCollection<ProductDefinition> products) { }

	[CompilerGenerated]
	[DebuggerHidden]
	[NullableContext(1)]
	private void <>n__1(ICart cart) { }

	public virtual void FetchProducts(IReadOnlyCollection<ProductDefinition> products) { }

	public virtual void Purchase(ICart cart) { }

}

