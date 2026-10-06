namespace UnityEngine.Purchasing;

public interface IGooglePlayStoreExtendedService : IStoreServiceExtension
{

	public void EndConnection() { }

	public void SetObfuscatedAccountId(string accountId) { }

	public void SetObfuscatedProfileId(string profileId) { }

}

