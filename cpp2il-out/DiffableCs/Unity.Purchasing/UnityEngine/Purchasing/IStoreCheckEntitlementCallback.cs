namespace UnityEngine.Purchasing;

public interface IStoreCheckEntitlementCallback
{

	public void OnCheckEntitlement(ProductDefinition productDefinition, EntitlementStatus status, string message = null) { }

}

