namespace UnityEngine.Purchasing.UseCases.Interfaces;

[NullableContext(1)]
internal interface IFetchStorePromotionOrderUseCase
{

	public void FetchStorePromotionOrder(Action<List`1<Product>> successCallback, Action<String> errorCallback) { }

}

