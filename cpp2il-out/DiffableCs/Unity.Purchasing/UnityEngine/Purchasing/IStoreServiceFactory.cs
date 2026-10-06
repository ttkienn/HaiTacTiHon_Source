namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IStoreServiceFactory
{

	public IStoreService Create(IStoreWrapper store, IRetryPolicy retryPolicy) { }

	public void RegisterNewExtendedService(string name, Func<IStoreService, ExtensibleStoreService> createFunction) { }

	public void RegisterNewService(string name, Func<IStoreService> createFunction) { }

}

