namespace UnityEngine.Purchasing.Telemetry;

internal interface ITelemetryMetricEvent
{

	public void StartMetric() { }

	public void StopAndSendMetric() { }

}

