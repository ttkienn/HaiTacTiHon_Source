namespace Unity.Services.Core.Analytics.Internal;

[RequireImplementors]
public interface IAnalyticsUserId : IServiceComponent
{

	public string GetAnalyticsUserId() { }

}

