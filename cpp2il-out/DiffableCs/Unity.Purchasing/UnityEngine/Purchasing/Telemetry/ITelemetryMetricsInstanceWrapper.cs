namespace UnityEngine.Purchasing.Telemetry;

internal interface ITelemetryMetricsInstanceWrapper
{

	public void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds) { }

	public void SetMetricsInstance(IMetrics metricsInstance) { }

}

