namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ProductServiceFactory : IProductServiceFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Func<IProductService> createFunction; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal IProductService <RegisterNewService>g__CreateCustomProductServiceDiscardParams|0(IStoreWrapper storeWrapper) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Func<IProductService, ExtensibleProductService> createFunction; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal IProductService <RegisterNewExtendedService>g__CreateCustomProductServiceDiscardParams|0(IStoreWrapper storeWrapper) { }

	}

	[Nullable(2)]
	private static ProductServiceFactory s_Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1, 1, 1}])]
	private readonly Dictionary<String, Func`2<IStoreWrapper, IProductService>> m_ProductServiceInstantiationByName; //Field offset: 0x10

	private ProductServiceFactory() { }

	private static void AddProductServiceDependencies(IStoreWrapper store, IDependencyInjectionService di) { }

	public override IProductService Create(IStoreWrapper store) { }

	private static AppleStoreExtendedProductService CreateAppleProductService(IStoreWrapper store) { }

	private static ProductService CreateGenericProductService(IStoreWrapper storeWrapper) { }

	internal static ProductServiceFactory Instance() { }

	public override void RegisterNewExtendedService(string name, Func<IProductService, ExtensibleProductService> createFunction) { }

	public override void RegisterNewService(string name, Func<IProductService> createFunction) { }

}

