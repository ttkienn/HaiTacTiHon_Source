namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class AppleRefreshAppReceiptUseCase : IRefreshAppReceiptUseCase
{
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x18

	[Preserve]
	internal AppleRefreshAppReceiptUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }

	public override void RefreshAppReceipt(Action<String> successCallback, Action<String> errorCallback) { }

	public override void SetRefreshAppReceipt(bool refreshAppReceipt) { }

}

