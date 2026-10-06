namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreServiceDependencyInjector
{
	[Nullable(2)]
	private readonly IRetryPolicy m_RetryPolicy; //Field offset: 0x10
	private readonly IStoreWrapper m_Store; //Field offset: 0x18
	private IStoreServiceFactoryManager m_ServiceFactoryManager; //Field offset: 0x20

	internal StoreServiceDependencyInjector(IStoreWrapper storeWrapper, IRetryPolicy retryPolicy) { }

	internal IStoreService CreateStoreService() { }

}

