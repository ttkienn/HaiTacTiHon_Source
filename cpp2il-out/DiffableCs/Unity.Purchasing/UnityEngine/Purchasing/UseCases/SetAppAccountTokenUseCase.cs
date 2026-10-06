namespace UnityEngine.Purchasing.UseCases;

internal class SetAppAccountTokenUseCase : ISetAppAccountTokenUseCase
{
	[Nullable(1)]
	private readonly IAppleStoreCallbacks m_AppleStoreCallbacks; //Field offset: 0x10

	[NullableContext(1)]
	[Preserve]
	internal SetAppAccountTokenUseCase(IAppleStoreCallbacks appleStoreCallbacks) { }

	public override void SetAppAccountToken(Guid token) { }

}

