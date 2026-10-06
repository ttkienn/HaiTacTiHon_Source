namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class StoreFactory : IStoreFactory
{
	[Nullable(2)]
	private static StoreFactory s_Instance; //Field offset: 0x0
	private readonly IUtil m_Util; //Field offset: 0x10
	private readonly ILogger m_Logger; //Field offset: 0x18
	private readonly INativeStoreProvider m_NativeStoreProvider; //Field offset: 0x20
	public readonly ITelemetryMetricsInstanceWrapper TelemetryMetricsInstanceWrapper; //Field offset: 0x28
	public readonly ITelemetryDiagnosticsInstanceWrapper TelemetryDiagnosticsInstanceWrapper; //Field offset: 0x30
	[Nullable(new IL2CPP_TYPE_U1[] {1, 2, 1, 1}])]
	private readonly Dictionary<String, Func`1<IStoreWrapper>> m_StoreInstantiationByName; //Field offset: 0x38

	internal StoreFactory(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	private void AddGooglePlayStoreServiceAars(IDependencyInjectionService di) { }

	private static void AddGooglePlayStoreServices(IDependencyInjectionService di) { }

	private void AddMetricizedAppleStoreDependencies(IDependencyInjectionService di) { }

	private void AddTelemetryDependencies(IDependencyInjectionService di) { }

	private void AddUtilsDependencies(IDependencyInjectionService di) { }

	private static ITransactionLog BuildTransactionLog() { }

	private void CreateAndAssignNativeAppleStore(AppleStoreImpl store) { }

	private IDependencyInjectionService CreateBaseDiService() { }

	private FakeStore CreateFakeStoreByUIMode(FakeStoreUIMode useFakeStoreUIMode) { }

	public override IStoreWrapper CreateStore(string storeName) { }

	private static IStoreWrapper CreateStoreWrapper(string storeName, IDependencyInjectionService di) { }

	internal static StoreFactory Instance() { }

	private IStoreWrapper InstantiateAppleAppStore(string storeName, string storeDisplayName) { }

	private IStoreWrapper InstantiateAppleStore() { }

	private IStoreWrapper InstantiateFakeStore() { }

	private IStoreWrapper InstantiateGooglePlayStore() { }

	private IStoreWrapper InstantiateMacAppStore() { }

	private void LinkGooglePlayStoreDependencies(IDependencyInjectionService di) { }

	private static void LinkProductCache(IDependencyInjectionService di) { }

	private void RegisterBaseStores() { }

	public override void RegisterStore(string storeName, Func<IStoreWrapper> function) { }

}

