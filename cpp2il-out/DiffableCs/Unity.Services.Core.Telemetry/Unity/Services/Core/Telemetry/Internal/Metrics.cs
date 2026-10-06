namespace Unity.Services.Core.Telemetry.Internal;

internal class Metrics : IMetrics
{
	[CompilerGenerated]
	private readonly IDictionary<String, String> <PackageTags>k__BackingField; //Field offset: 0x10

	public Metrics() { }

	private override void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, IDictionary<String, String> tags) { }

	private override void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, IDictionary<String, String> tags) { }

	private override void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, IDictionary<String, String> tags) { }

}

