namespace UnityEngine.Purchasing.UseCases;

internal class SimulateAskToBuyUseCase : ISimulateAskToBuyUseCase
{
	[Nullable(1)]
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	internal SimulateAskToBuyUseCase(IAppleStoreCallbacks appleStoreCallbacks) { }

	public override void SetSimulateAskToBuy(bool value) { }

	public override bool SimulateAskToBuy() { }

}

