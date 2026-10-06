namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ProductServiceDependencyInjector
{
	private IStoreWrapper m_storeWrapper; //Field offset: 0x10
	private IProductServiceFactoryManager m_ServiceFactoryManager; //Field offset: 0x18

	internal ProductServiceDependencyInjector(IStoreWrapper storeWrapper) { }

	internal IProductService CreateProductService() { }

}

