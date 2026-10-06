namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class FetchStorePromotionVisibilityUseCase : IFetchStorePromotionVisibilityUseCase
{
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x18

	[Preserve]
	internal FetchStorePromotionVisibilityUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }

	public override void FetchStorePromotionVisibility(Product product, Action<String, AppleStorePromotionVisibility> successCallback, Action<String> errorCallback) { }

}

