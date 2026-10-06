namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryDiagnostics : ITelemetryDiagnostics
{
	private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper; //Field offset: 0x10

	[Preserve]
	internal TelemetryDiagnostics(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper) { }

	public override void SendDiagnostic(string diagnosticName, Exception e) { }

}

