namespace UnityEngine.Purchasing.UseCases.Interfaces;

[NullableContext(1)]
internal interface IFetchStorePromotionVisibilityUseCase
{

	public void FetchStorePromotionVisibility(Product product, Action<String, AppleStorePromotionVisibility> successCallback, Action<String> errorCallback) { }

}

