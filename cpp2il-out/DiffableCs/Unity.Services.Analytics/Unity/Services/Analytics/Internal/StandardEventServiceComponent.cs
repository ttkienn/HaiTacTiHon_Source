namespace Unity.Services.Analytics.Internal;

internal class StandardEventServiceComponent : IAnalyticsStandardEventComponent, IServiceComponent
{
	private readonly IProjectConfiguration m_Configuration; //Field offset: 0x10
	private readonly IUnstructuredEventRecorder m_AnalyticsService; //Field offset: 0x18

	public StandardEventServiceComponent(IProjectConfiguration configuration, IUnstructuredEventRecorder analyticsService) { }

	public override void Record(string eventName, IDictionary<String, Object> eventParameters, int eventVersion, string packageName) { }

}

