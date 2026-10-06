namespace UnityEngine.Purchasing;

internal class GooglePlayStorePurchaseService : IGooglePlayStorePurchaseService
{
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x10

	[Preserve]
	internal GooglePlayStorePurchaseService(IGooglePlayStoreService googlePlayStoreService) { }

	public override void Purchase(ProductDefinition product) { }

}

