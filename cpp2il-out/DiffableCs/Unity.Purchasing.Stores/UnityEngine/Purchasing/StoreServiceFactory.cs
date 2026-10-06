namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreServiceFactory : IStoreServiceFactory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Func<IStoreService> createFunction; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal IStoreService <RegisterNewService>g__CreateCustomStoreServiceDiscardParams|0(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Func<IStoreService, ExtensibleStoreService> createFunction; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal IStoreService <RegisterNewExtendedService>g__CreateCustomStoreServiceDiscardParams|0(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper) { }

	}

	[Nullable(2)]
	private static StoreServiceFactory s_Instance; //Field offset: 0x0
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1, 1, 1, 1}])]
	private readonly Dictionary<String, Func`3<IRetryPolicy, IStoreWrapper, IStoreService>> m_StoreServiceInstantiationByName; //Field offset: 0x10

	private StoreServiceFactory() { }

	private static void AddStoreServiceDependencies(IDependencyInjectionService di, IRetryPolicy retryPolicy, IStoreWrapper store) { }

	public override IStoreService Create(IStoreWrapper store, IRetryPolicy retryPolicy) { }

	private static AppleStoreExtendedService CreateAppleStoreService(IRetryPolicy retryPolicy, IStoreWrapper store) { }

	private static StoreService CreateGenericStoreService(IRetryPolicy retryPolicy, IStoreWrapper storeWrapper) { }

	private static GooglePlayStoreExtendedService CreateGoogleStoreService(IRetryPolicy retryPolicy, IStoreWrapper store) { }

	internal static StoreServiceFactory Instance() { }

	public override void RegisterNewExtendedService(string name, Func<IStoreService, ExtensibleStoreService> createFunction) { }

	public override void RegisterNewService(string name, Func<IStoreService> createFunction) { }

}

