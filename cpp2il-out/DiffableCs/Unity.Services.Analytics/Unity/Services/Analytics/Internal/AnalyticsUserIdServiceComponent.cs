namespace Unity.Services.Analytics.Internal;

internal class AnalyticsUserIdServiceComponent : IAnalyticsUserId, IServiceComponent
{
	private readonly IAnalyticsService m_AnalyticsService; //Field offset: 0x10

	public AnalyticsUserIdServiceComponent(IAnalyticsService analyticsService) { }

	public override string GetAnalyticsUserId() { }

}

