namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal static class ProductServiceProvider
{

	private static IProductService CreateNewService(IStoreWrapper wrapper) { }

	public static IProductService GetDefaultProductService() { }

	public static IProductService GetProductService(string storeName) { }

	private static IProductService GetProductServiceInternal(IStoreWrapper storeWrapper) { }

	private static IProductService LocateExistingService(IStoreWrapper wrapper) { }

}

