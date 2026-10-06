namespace UnityEngine.Purchasing;

internal interface IProductServiceFactory
{

	public IProductService Create(IStoreWrapper store) { }

	public void RegisterNewExtendedService(string name, Func<IProductService, ExtensibleProductService> createFunction) { }

	public void RegisterNewService(string name, Func<IProductService> createFunction) { }

}

