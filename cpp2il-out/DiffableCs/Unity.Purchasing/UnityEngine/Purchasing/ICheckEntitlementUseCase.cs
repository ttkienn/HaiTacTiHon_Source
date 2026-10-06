namespace UnityEngine.Purchasing;

internal interface ICheckEntitlementUseCase
{

	public void IsProductEntitled(Product product, Action<Entitlement> onResult) { }

}

