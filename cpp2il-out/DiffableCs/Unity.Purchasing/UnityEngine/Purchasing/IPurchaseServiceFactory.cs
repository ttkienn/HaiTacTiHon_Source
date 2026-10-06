namespace UnityEngine.Purchasing;

internal interface IPurchaseServiceFactory
{

	public IPurchaseService Create(IStoreWrapper store) { }

	public void RegisterNewExtendedService(string name, Func<IPurchaseService, ExtensiblePurchaseService> createFunction) { }

	public void RegisterNewService(string name, Func<IPurchaseService> createFunction) { }

}

