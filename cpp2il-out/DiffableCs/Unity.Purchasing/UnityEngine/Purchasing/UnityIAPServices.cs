namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public static class UnityIAPServices
{

	public static void AddNewCustomStore(IStoreWrapper customStoreWrapper) { }

	public static void AddNewExtendedProductService(string storeName, Func<IProductService, ExtensibleProductService> createProductService) { }

	public static void AddNewExtendedPurchaseService(string storeName, Func<IPurchaseService, ExtensiblePurchaseService> createPurchaseService) { }

	public static void AddNewExtendedStoreService(string storeName, Func<IStoreService, ExtensibleStoreService> createStoreService) { }

	public static void AddNewProductService(string storeName, Func<IProductService> createProductService) { }

	public static void AddNewPurchaseService(string storeName, Func<IPurchaseService> createPurchaseService) { }

	public static void AddNewStoreService(string storeName, Func<IStoreService> createStoreService) { }

	public static IProductService DefaultProduct() { }

	public static IPurchaseService DefaultPurchase() { }

	public static IStoreService DefaultStore() { }

	public static IProductService Product(string storeName) { }

	public static IPurchaseService Purchase(string storeName) { }

	public static void SetStoreAsDefault(string storeName) { }

	public static IStoreService Store(string storeName) { }

	public static StoreController StoreController(string storeName = null) { }

}

