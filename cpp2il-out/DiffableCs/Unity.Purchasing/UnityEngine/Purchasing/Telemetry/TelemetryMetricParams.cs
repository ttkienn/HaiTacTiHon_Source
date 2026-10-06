namespace UnityEngine.Purchasing.Telemetry;

internal struct TelemetryMetricParams
{
	internal TelemetryMetricTypes type; //Field offset: 0x0
	internal string name; //Field offset: 0x8
	internal double timeSeconds; //Field offset: 0x10

	internal TelemetryMetricParams(TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds) { }

}

