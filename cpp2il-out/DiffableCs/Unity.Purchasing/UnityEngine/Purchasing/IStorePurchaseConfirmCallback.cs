namespace UnityEngine.Purchasing;

public interface IStorePurchaseConfirmCallback
{

	public void OnConfirmOrderFailed(FailedOrder failedOrder) { }

	public void OnConfirmOrderSucceeded(string transactionId) { }

}

