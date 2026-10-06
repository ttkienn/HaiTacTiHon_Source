namespace UnityEngine.Purchasing;

internal interface IAnalyticsAdapter
{

	public void SendTransactionEvent(CartItem item, string receipt) { }

	public void SendTransactionFailedEvent(PurchaseFailureDescription failureDescription) { }

}

