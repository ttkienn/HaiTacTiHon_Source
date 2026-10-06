namespace UnityEngine.Purchasing.UseCases;

[Nullable(0)]
[NullableContext(1)]
internal class AppleRestoreTransactionsUseCase : IRestoreTransactionsUseCase
{
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10
	private readonly INativeAppleStore m_NativeAppleStore; //Field offset: 0x18

	[Preserve]
	internal AppleRestoreTransactionsUseCase(IAppleStoreCallbacks appleStoreCallbacks, INativeAppleStore nativeStore) { }

	[NullableContext(2)]
	public override void RestoreTransactions(Action<Boolean, String> callback) { }

}

