namespace UnityEngine.Purchasing.Interfaces;

internal interface IGooglePlayStoreCheckEntitlementService
{

	public void CheckEntitlement(ProductDefinition product) { }

	public void SetCheckEntitlementCallback(IStoreCheckEntitlementCallback entitlementCallback) { }

}

