namespace UnityEngine.Purchasing;

internal interface IAnalyticsClient
{

	public void OnPurchaseFailed(FailedOrder failedOrder) { }

	public void OnPurchaseSucceeded(ConfirmedOrder confirmedOrder) { }

}

