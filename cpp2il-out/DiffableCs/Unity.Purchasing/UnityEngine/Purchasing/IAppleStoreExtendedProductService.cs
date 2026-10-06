namespace UnityEngine.Purchasing;

public interface IAppleStoreExtendedProductService : IProductServiceExtension
{

	public void FetchStorePromotionOrder(Action<List`1<Product>> successCallback, Action<String> errorCallback) { }

	public void FetchStorePromotionVisibility(Product product, Action<String, AppleStorePromotionVisibility> successCallback, Action<String> errorCallback) { }

	public Dictionary<String, String> GetIntroductoryPriceDictionary() { }

	public Dictionary<String, String> GetProductDetails() { }

	public void SetStorePromotionOrder(List<Product> products) { }

	public void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible) { }

}

