namespace Unity.Services.Analytics;

internal class AnalyticsServiceSystemCalls : IAnalyticsServiceSystemCalls
{

	public override DateTime UtcNow
	{
		 get { } //Length: 64
	}

	public AnalyticsServiceSystemCalls() { }

	public override DateTime get_UtcNow() { }

}

