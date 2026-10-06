namespace UnityEngine.Purchasing;

internal class GooglePlayStoreConnectionUseCase : IGooglePlayStoreConnectionUseCase
{
	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10

	[Preserve]
	public GooglePlayStoreConnectionUseCase(IGoogleBillingClient billingClient) { }

	public override void EndConnection() { }

}

