namespace UnityEngine.Purchasing;

internal class PurchaseServiceFactoryManager : IPurchaseServiceFactoryManager, IPurchaseServiceFactoryManagerInjectionPoint
{
	private static PurchaseServiceFactoryManager s_Instance; //Field offset: 0x0
	private IPurchaseServiceFactory m_Factory; //Field offset: 0x10

	public PurchaseServiceFactoryManager() { }

	public override IPurchaseServiceFactory GetServiceFactory() { }

	internal static PurchaseServiceFactoryManager Instance() { }

	public override void SetServiceFactory(IPurchaseServiceFactory serviceFactory) { }

}

