namespace Unity.Services.Core.Telemetry.Internal;

public interface IMetricsFactory : IServiceComponent
{

	public IReadOnlyDictionary<String, String> CommonTags
	{
		 get { } //Length: 0
	}

	public IMetrics Create(string packageName) { }

	public IReadOnlyDictionary<String, String> get_CommonTags() { }

}

