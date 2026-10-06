namespace UnityEngine.Purchasing;

internal class PurchaseServiceDependencyInjector
{
	private IStoreWrapper m_storeWrapper; //Field offset: 0x10
	private IPurchaseServiceFactoryManager m_ServiceFactoryManager; //Field offset: 0x18

	internal PurchaseServiceDependencyInjector(IStoreWrapper storeWrapper) { }

	internal IPurchaseService CreatePurchaseService() { }

}

