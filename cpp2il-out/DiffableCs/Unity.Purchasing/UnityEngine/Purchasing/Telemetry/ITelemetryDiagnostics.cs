namespace UnityEngine.Purchasing.Telemetry;

internal interface ITelemetryDiagnostics
{

	public void SendDiagnostic(string diagnosticName, Exception e) { }

}

