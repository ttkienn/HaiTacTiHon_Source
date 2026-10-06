namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreManager : IStoreManager, IStoreManagerFactoryInjectionPoint
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		[Nullable(0)]
		public IStoreWrapper customStore; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal IStoreWrapper <AddNewCustomStore>g__InstantiateCustomStore|0() { }

	}

	[Nullable(2)]
	private static StoreManager s_Instance; //Field offset: 0x0
	[Nullable(2)]
	private IStoreFactory m_StoreFactory; //Field offset: 0x10
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1}])]
	private readonly Dictionary<String, IStoreWrapper> m_InstantiatedStores; //Field offset: 0x18

	public StoreManager() { }

	public void AddNewCustomStore(IStoreWrapper customStore) { }

	public IStoreWrapper GetDefaultStore() { }

	public override IStoreWrapper GetStore(string name) { }

	public static StoreManager Instance() { }

	[NullableContext(2)]
	public override void SetStoreFactory(IStoreFactory storeFactory) { }

}

