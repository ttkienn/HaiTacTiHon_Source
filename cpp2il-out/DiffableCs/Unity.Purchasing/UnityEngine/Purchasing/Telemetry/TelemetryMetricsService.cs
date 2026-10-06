namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryMetricsService : ITelemetryMetricsService
{
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; //Field offset: 0x10

	public TelemetryMetricsService(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	public override ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition) { }

	public override void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

}

