namespace UnityEngine.Purchasing.Telemetry;

internal interface ITelemetryMetricsService
{

	public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition) { }

	public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

}

