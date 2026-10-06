namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class PurchaseServiceContainer
{
	[Nullable(2)]
	private static PurchaseServiceContainer s_Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1}])]
	private readonly Dictionary<String, IPurchaseService> m_InstantiatedServices; //Field offset: 0x10

	public PurchaseServiceContainer() { }

	internal IPurchaseService FindService(string storeName) { }

	internal static PurchaseServiceContainer Instance() { }

	internal void SetService(string storeName, IPurchaseService service) { }

}

