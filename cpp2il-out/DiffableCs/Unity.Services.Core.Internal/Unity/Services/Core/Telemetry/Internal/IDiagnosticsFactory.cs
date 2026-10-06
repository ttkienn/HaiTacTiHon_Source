namespace Unity.Services.Core.Telemetry.Internal;

public interface IDiagnosticsFactory : IServiceComponent
{

	public IReadOnlyDictionary<String, String> CommonTags
	{
		 get { } //Length: 0
	}

	public IDiagnostics Create(string packageName) { }

	public IReadOnlyDictionary<String, String> get_CommonTags() { }

}

