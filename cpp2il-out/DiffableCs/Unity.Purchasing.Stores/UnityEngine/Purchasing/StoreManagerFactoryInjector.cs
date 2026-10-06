namespace UnityEngine.Purchasing;

internal static class StoreManagerFactoryInjector
{

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void SetStoreManagerFactory() { }

}

