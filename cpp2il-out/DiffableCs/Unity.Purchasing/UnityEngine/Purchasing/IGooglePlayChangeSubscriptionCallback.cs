namespace UnityEngine.Purchasing;

internal interface IGooglePlayChangeSubscriptionCallback : IStorePurchaseCallback
{

	public void OnSubscriptionChange(string storeSpecificId) { }

	public void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId) { }

}

