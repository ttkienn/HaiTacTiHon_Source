namespace UnityEngine.Purchasing;

internal class GooglePlayStoreSetObfuscatedIdUseCase : IGooglePlayStoreSetObfuscatedIdUseCase
{
	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10

	[Preserve]
	internal GooglePlayStoreSetObfuscatedIdUseCase(IGoogleBillingClient billingClient) { }

	public override void SetObfuscatedAccountId(string accountId) { }

	public override void SetObfuscatedProfileId(string profileId) { }

}

