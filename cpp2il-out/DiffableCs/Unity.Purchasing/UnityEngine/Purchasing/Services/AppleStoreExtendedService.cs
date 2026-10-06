namespace UnityEngine.Purchasing.Services;

[Nullable(0)]
[NullableContext(1)]
internal class AppleStoreExtendedService : StoreService, IAppleStoreExtendedService, IStoreServiceExtension
{
	private readonly ICanMakePaymentsUseCase m_CanMakePaymentsUseCase; //Field offset: 0x18
	private readonly IClearAppleTransactionLogsUseCase m_ClearAppleTransactionLogsUseCase; //Field offset: 0x20
	private readonly ISetAppAccountTokenUseCase m_SetAppAccountTokenUseCase; //Field offset: 0x28

	public override bool canMakePayments
	{
		 get { } //Length: 70
	}

	[Preserve]
	internal AppleStoreExtendedService(ICanMakePaymentsUseCase canMakePaymentsUseCase, IClearAppleTransactionLogsUseCase clearAppleTransactionLogsUseCase, ISetAppAccountTokenUseCase setAppAccountTokenUseCase, IStoreConnectUseCase connectUseCase) { }

	public override void ClearTransactionLog() { }

	public override bool get_canMakePayments() { }

	public override void SetAppAccountToken(Guid appAccountToken) { }

}

