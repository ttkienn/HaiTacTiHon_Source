namespace Unity.Services.Core.Telemetry.Internal;

internal class MetricsFactory : IMetricsFactory, IServiceComponent
{
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<String, String> <CommonTags>k__BackingField; //Field offset: 0x10

	public override IReadOnlyDictionary<String, String> CommonTags
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MetricsFactory() { }

	public override IMetrics Create(string packageName) { }

	[CompilerGenerated]
	public override IReadOnlyDictionary<String, String> get_CommonTags() { }

}

