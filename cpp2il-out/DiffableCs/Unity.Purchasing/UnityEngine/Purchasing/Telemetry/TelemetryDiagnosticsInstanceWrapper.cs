namespace UnityEngine.Purchasing.Telemetry;

internal class TelemetryDiagnosticsInstanceWrapper : ITelemetryDiagnosticsInstanceWrapper
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TelemetryDiagnosticsInstanceWrapper <>4__this; //Field offset: 0x10
		public TelemetryDiagnosticParams diagnosticParams; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <SendDiagnosticOnMainThread>b__0() { }

	}

	private IDiagnostics m_Instance; //Field offset: 0x10
	private ILogger m_Logger; //Field offset: 0x18
	private IUtil m_Util; //Field offset: 0x20
	private readonly TelemetryQueue<TelemetryDiagnosticParams> m_Queue; //Field offset: 0x28

	internal TelemetryDiagnosticsInstanceWrapper(ILogger logger, IUtil util) { }

	public override void SendDiagnostic(string diagnosticName, string diagnosticException) { }

	private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams) { }

	private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams) { }

	public override void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

}

