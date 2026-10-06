namespace UnityEngine.Purchasing.Telemetry;

internal interface ITelemetryDiagnosticsInstanceWrapper
{

	public void SendDiagnostic(string diagnosticName, string diagnosticException) { }

	public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

}

