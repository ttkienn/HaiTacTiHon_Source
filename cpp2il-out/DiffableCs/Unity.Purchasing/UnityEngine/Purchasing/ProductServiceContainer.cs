namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ProductServiceContainer
{
	[Nullable(2)]
	private static ProductServiceContainer s_Instance; //Field offset: 0x0
	private readonly Dictionary<String, IProductService> m_InstantiatedServices; //Field offset: 0x10

	public ProductServiceContainer() { }

	internal IProductService FindService(string storeName) { }

	internal static ProductServiceContainer Instance() { }

	internal void SetService(string storeName, IProductService service) { }

}

