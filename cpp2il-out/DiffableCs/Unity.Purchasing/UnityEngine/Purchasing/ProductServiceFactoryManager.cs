namespace UnityEngine.Purchasing;

internal class ProductServiceFactoryManager : IProductServiceFactoryManager, IProductServiceFactoryManagerInjectionPoint
{
	private static ProductServiceFactoryManager s_Instance; //Field offset: 0x0
	private IProductServiceFactory m_Factory; //Field offset: 0x10

	public ProductServiceFactoryManager() { }

	public override IProductServiceFactory GetServiceFactory() { }

	internal static ProductServiceFactoryManager Instance() { }

	public override void SetServiceFactory(IProductServiceFactory serviceFactory) { }

}

