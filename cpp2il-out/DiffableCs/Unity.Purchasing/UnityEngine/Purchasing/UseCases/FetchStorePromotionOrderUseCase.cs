namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class FetchStorePromotionOrderUseCase : IFetchStorePromotionOrderUseCase
{
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x18

	[Preserve]
	internal FetchStorePromotionOrderUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }

	public override void FetchStorePromotionOrder(Action<List`1<Product>> successCallback, Action<String> errorCallback) { }

}

