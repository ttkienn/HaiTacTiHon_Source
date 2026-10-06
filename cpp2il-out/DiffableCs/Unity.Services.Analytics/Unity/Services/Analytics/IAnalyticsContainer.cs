namespace Unity.Services.Analytics;

internal interface IAnalyticsContainer
{

	public void Disable() { }

	public void Enable() { }

	public void Initialize(AnalyticsServiceInstance service) { }

}

