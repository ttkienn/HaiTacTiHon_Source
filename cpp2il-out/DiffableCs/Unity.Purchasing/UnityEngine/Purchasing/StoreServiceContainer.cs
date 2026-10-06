namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreServiceContainer
{
	[Nullable(2)]
	private static StoreServiceContainer s_Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1}])]
	private readonly Dictionary<String, IStoreService> m_InstantiatedServices; //Field offset: 0x10

	public StoreServiceContainer() { }

	internal IStoreService FindService(string storeName) { }

	internal static StoreServiceContainer Instance() { }

	internal void SetService(string storeName, IStoreService service) { }

}

