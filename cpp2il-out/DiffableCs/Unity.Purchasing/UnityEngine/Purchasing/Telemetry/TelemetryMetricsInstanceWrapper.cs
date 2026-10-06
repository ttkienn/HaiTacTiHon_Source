namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryMetricsInstanceWrapper : ITelemetryMetricsInstanceWrapper
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TelemetryMetricsInstanceWrapper <>4__this; //Field offset: 0x10
		public TelemetryMetricParams metricParams; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <SendMetricOnMainThread>b__0() { }

	}

	private IMetrics m_Instance; //Field offset: 0x10
	private ILogger m_Logger; //Field offset: 0x18
	private IUtil m_Util; //Field offset: 0x20
	private readonly TelemetryQueue<TelemetryMetricParams> m_Queue; //Field offset: 0x28

	internal TelemetryMetricsInstanceWrapper(ILogger logger, IUtil util) { }

	public override void SendMetric(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds) { }

	private void SendMetricByType(TelemetryMetricParams metricParams) { }

	private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams) { }

	private void SendMetricOnMainThread(TelemetryMetricParams metricParams) { }

	public override void SetMetricsInstance(IMetrics metricsInstance) { }

}

