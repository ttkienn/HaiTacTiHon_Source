namespace UnityEngine.Purchasing;

internal interface IGooglePlayStore : IStore
{

	public void ChangeSubscription(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	public IGooglePurchase GetGooglePurchase(string purchaseToken) { }

	public void OnPause(bool isPaused) { }

	public void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback) { }

}

