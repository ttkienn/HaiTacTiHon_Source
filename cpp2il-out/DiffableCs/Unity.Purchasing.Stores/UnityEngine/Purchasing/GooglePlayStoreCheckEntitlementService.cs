namespace UnityEngine.Purchasing;

internal class GooglePlayStoreCheckEntitlementService : IGooglePlayStoreCheckEntitlementService
{
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; //Field offset: 0x10
	private IStoreCheckEntitlementCallback m_EntitlementCallback; //Field offset: 0x18

	[Preserve]
	internal GooglePlayStoreCheckEntitlementService(IGooglePlayStoreService googlePlayStoreService) { }

	[CompilerGenerated]
	[NullableContext(1)]
	private void <CheckEntitlement>b__3_0(ProductDefinition checkedProduct, EntitlementStatus status) { }

	public override void CheckEntitlement(ProductDefinition product) { }

	public override void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

}

