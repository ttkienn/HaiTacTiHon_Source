namespace UnityEngine.Purchasing.Services;

[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreExtendedProductService : ProductService, IAppleStoreExtendedProductService, IProductServiceExtension
{
	private readonly IFetchStorePromotionOrderUseCase m_FetchStorePromotionOrderUseCase; //Field offset: 0x38
	private readonly IFetchStorePromotionVisibilityUseCase m_FetchStorePromotionVisibilityUseCase; //Field offset: 0x40
	private readonly IGetIntroductoryPriceDictionaryUseCase m_GetIntroductoryPriceDictionaryUseCase; //Field offset: 0x48
	private readonly IGetProductDetailsUseCase m_GetProductDetailsUseCase; //Field offset: 0x50
	private readonly ISetStorePromotionOrderUseCase m_SetStorePromotionOrderUseCase; //Field offset: 0x58
	private readonly ISetStorePromotionVisibilityUseCase m_SetStorePromotionVisibilityUseCase; //Field offset: 0x60

	[Preserve]
	internal AppleStoreExtendedProductService(IFetchStorePromotionOrderUseCase fetchStorePromotionOrderUseCase, IFetchStorePromotionVisibilityUseCase fetchStorePromotionVisibilityUseCase, IGetIntroductoryPriceDictionaryUseCase getIntroductoryPriceDictionaryUseCase, IGetProductDetailsUseCase getProductDetailsUseCase, ISetStorePromotionOrderUseCase setStorePromotionOrderUseCase, ISetStorePromotionVisibilityUseCase setStorePromotionVisibilityUseCase, IFetchProductsUseCase fetchProductsUseCase, IStoreWrapper storeWrapper) { }

	public override void FetchStorePromotionOrder(Action<List`1<Product>> successCallback, Action<String> errorCallback) { }

	public override void FetchStorePromotionVisibility(Product product, Action<String, AppleStorePromotionVisibility> successCallback, Action<String> errorCallback) { }

	public override Dictionary<String, String> GetIntroductoryPriceDictionary() { }

	public override Dictionary<String, String> GetProductDetails() { }

	public override void SetStorePromotionOrder(List<Product> products) { }

	public override void SetStorePromotionVisibility(Product product, AppleStorePromotionVisibility visible) { }

}

