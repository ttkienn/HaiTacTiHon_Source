namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal static class StoreServiceProvider
{

	private static IStoreService CreateNewService(IStoreWrapper wrapper) { }

	public static IStoreService GetDefaultStoreService() { }

	public static IStoreService GetStoreService(string storeName) { }

	private static IStoreService GetStoreServiceInternal(IStoreWrapper storeWrapper) { }

	private static IStoreService LocateExistingService(IStoreWrapper wrapper) { }

}

