namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class PurchaseServiceFactory : IPurchaseServiceFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Func<IPurchaseService> createFunction; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal IPurchaseService <RegisterNewService>g__CreateCustomProductServiceDiscardParams|0(IStoreWrapper storeWrapper) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Func<IPurchaseService, ExtensiblePurchaseService> createFunction; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal IPurchaseService <RegisterNewExtendedService>g__CreateCustomProductServiceDiscardParams|0(IStoreWrapper storeWrapper) { }

	}

	[Nullable(2)]
	private static PurchaseServiceFactory s_Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1, 1, 1}])]
	private readonly Dictionary<String, Func`2<IStoreWrapper, IPurchaseService>> m_PurchaseServiceInstantiationByName; //Field offset: 0x10

	private PurchaseServiceFactory() { }

	private static void AddAnalyticsDependencies(IDependencyInjectionService di) { }

	private static void AddPurchaseServiceDependencies(IStoreWrapper store, IDependencyInjectionService di) { }

	public override IPurchaseService Create(IStoreWrapper store) { }

	private static AppleStoreExtendedPurchaseService CreateApplePurchaseService(IStoreWrapper store) { }

	private static PurchaseService CreateDefaultPurchaseService(IStoreWrapper store) { }

	private static GooglePlayStoreExtendedPurchaseService CreateGooglePurchaseService(IStoreWrapper store) { }

	internal static PurchaseServiceFactory Instance() { }

	public override void RegisterNewExtendedService(string name, Func<IPurchaseService, ExtensiblePurchaseService> createFunction) { }

	public override void RegisterNewService(string name, Func<IPurchaseService> createFunction) { }

}

