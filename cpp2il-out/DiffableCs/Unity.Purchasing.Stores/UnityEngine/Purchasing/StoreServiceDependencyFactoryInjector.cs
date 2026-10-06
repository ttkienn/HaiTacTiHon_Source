namespace UnityEngine.Purchasing;

internal static class StoreServiceDependencyFactoryInjector
{

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void SetStoreManagerFactory() { }

}

