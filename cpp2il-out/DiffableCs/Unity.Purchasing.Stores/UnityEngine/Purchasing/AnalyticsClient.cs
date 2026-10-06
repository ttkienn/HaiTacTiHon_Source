namespace UnityEngine.Purchasing;

internal class AnalyticsClient : IAnalyticsClient
{
	private readonly IAnalyticsAdapter m_Analytics; //Field offset: 0x10

	[Preserve]
	internal AnalyticsClient(IAnalyticsAdapter analytics) { }

	public override void OnPurchaseFailed(FailedOrder failedOrder) { }

	public override void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder) { }

}

