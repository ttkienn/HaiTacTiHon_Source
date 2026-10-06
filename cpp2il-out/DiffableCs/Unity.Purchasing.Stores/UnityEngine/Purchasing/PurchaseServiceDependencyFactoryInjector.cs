namespace UnityEngine.Purchasing;

internal static class PurchaseServiceDependencyFactoryInjector
{

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void SetStoreManagerFactory() { }

}

