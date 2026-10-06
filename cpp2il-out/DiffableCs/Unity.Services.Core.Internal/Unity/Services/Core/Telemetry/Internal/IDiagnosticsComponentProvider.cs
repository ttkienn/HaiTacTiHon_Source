namespace Unity.Services.Core.Telemetry.Internal;

internal interface IDiagnosticsComponentProvider
{

	public Task<IDiagnosticsFactory> CreateDiagnosticsComponents() { }

	public Task<String> GetSerializedProjectConfigurationAsync() { }

}

