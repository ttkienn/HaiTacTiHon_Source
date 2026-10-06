namespace UnityEngine.Purchasing.Telemetry;

internal struct TelemetryDiagnosticParams
{
	internal string name; //Field offset: 0x0
	internal string exception; //Field offset: 0x8

	internal TelemetryDiagnosticParams(string diagnosticName, string diagnosticException) { }

}

