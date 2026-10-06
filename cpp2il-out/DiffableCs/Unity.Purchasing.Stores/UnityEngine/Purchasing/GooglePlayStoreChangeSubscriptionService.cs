namespace UnityEngine.Purchasing;

internal class GooglePlayStoreChangeSubscriptionService : IGooglePlayStoreChangeSubscriptionService
{
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x10

	[Preserve]
	internal GooglePlayStoreChangeSubscriptionService(IGooglePlayStoreService googlePlayStoreService) { }

	public override void ChangeSubscription(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

}

