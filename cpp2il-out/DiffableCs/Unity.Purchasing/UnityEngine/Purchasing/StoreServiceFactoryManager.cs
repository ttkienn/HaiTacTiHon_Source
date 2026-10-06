namespace UnityEngine.Purchasing;

internal class StoreServiceFactoryManager : IStoreServiceFactoryManager, IStoreServiceFactoryManagerInjectionPoint
{
	private static StoreServiceFactoryManager s_Instance; //Field offset: 0x0
	private IStoreServiceFactory m_Factory; //Field offset: 0x10

	public StoreServiceFactoryManager() { }

	public override IStoreServiceFactory GetServiceFactory() { }

	internal static StoreServiceFactoryManager Instance() { }

	public override void SetServiceFactory(IStoreServiceFactory serviceFactory) { }

}

