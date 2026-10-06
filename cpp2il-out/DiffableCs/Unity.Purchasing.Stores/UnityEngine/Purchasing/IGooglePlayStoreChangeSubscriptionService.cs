namespace UnityEngine.Purchasing;

internal interface IGooglePlayStoreChangeSubscriptionService
{

	public void ChangeSubscription(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

}

