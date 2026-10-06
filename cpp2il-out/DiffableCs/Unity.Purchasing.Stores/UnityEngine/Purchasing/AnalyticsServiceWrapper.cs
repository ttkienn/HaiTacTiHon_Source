namespace UnityEngine.Purchasing;

[Preserve]
internal class AnalyticsServiceWrapper : IAnalyticsServiceWrapper
{

	public AnalyticsServiceWrapper() { }

	[NullableContext(2)]
	public override IAnalyticsService AnalyticsServiceInstance() { }

}

