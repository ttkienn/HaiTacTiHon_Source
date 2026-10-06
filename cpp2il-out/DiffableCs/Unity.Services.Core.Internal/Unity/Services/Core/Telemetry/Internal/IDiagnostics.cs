namespace Unity.Services.Core.Telemetry.Internal;

public interface IDiagnostics
{

	public void SendDiagnostic(string name, string message, IDictionary<String, String> tags = null) { }

}

