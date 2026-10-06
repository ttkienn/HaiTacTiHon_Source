namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryMetricEvent : ITelemetryMetricEvent
{
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; //Field offset: 0x10
	private readonly TelemetryMetricTypes m_MetricType; //Field offset: 0x18
	private readonly string m_MetricName; //Field offset: 0x20
	private Stopwatch m_Stopwatch; //Field offset: 0x28

	internal TelemetryMetricEvent(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName) { }

	public override void StartMetric() { }

	public override void StopAndSendMetric() { }

}

