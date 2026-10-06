namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal static class PurchaseServiceProvider
{

	private static IPurchaseService CreateNewService(IStoreWrapper wrapper) { }

	public static IPurchaseService GetDefaultPurchaseService() { }

	public static IPurchaseService GetPurchaseService(string storeName) { }

	private static IPurchaseService GetPurchaseServiceInternal(IStoreWrapper storeWrapper) { }

	private static IPurchaseService LocateExistingService(IStoreWrapper wrapper) { }

}

