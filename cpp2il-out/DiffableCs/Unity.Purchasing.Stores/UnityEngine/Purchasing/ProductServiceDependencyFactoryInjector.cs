namespace UnityEngine.Purchasing;

internal static class ProductServiceDependencyFactoryInjector
{

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void SetStoreManagerFactory() { }

}

