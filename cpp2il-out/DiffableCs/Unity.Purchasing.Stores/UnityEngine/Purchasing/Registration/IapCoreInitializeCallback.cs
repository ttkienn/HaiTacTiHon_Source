namespace UnityEngine.Purchasing.Registration;

internal class IapCoreInitializeCallback : IInitializablePackage
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public CoreRegistry registry; //Field offset: 0x10
		public ITelemetryMetricsInstanceWrapper metricsInstanceWrapper; //Field offset: 0x18
		public ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <Initialize>b__0() { }

	}

	private const string k_PurchasingPackageName = "com.unity.purchasing"; //Field offset: 0x0

	public IapCoreInitializeCallback() { }

	private static void CacheInitializedEnvironment(CoreRegistry registry) { }

	private static string GetCurrentEnvironment(CoreRegistry registry) { }

	public override Task Initialize(CoreRegistry registry) { }

	private static void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper) { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Register() { }

}

