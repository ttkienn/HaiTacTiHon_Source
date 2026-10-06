namespace UnityEngine.Purchasing.UseCases.Interfaces;

internal class ClearAppleTransactionLogsUseCase : IClearAppleTransactionLogsUseCase
{
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10

	[Preserve]
	internal ClearAppleTransactionLogsUseCase(IAppleStoreCallbacks appleStoreCallbacks) { }

	public override void ClearTransactionLog() { }

}

