namespace UnityEngine.Purchasing.Interfaces;

internal interface IGooglePlayCheckEntitlementUseCase
{

	public void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked) { }

}

