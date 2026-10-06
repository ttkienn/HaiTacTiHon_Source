namespace Unity.Services.Core.Device;

internal class InstallationId : IInstallationId, IServiceComponent
{
	internal string Identifier; //Field offset: 0x10
	internal IUserIdentifierProvider UnityAdsIdentifierProvider; //Field offset: 0x18
	internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider; //Field offset: 0x20

	public InstallationId() { }

	public void CreateIdentifier() { }

	private static string GenerateGuid() { }

	public override string GetOrCreateIdentifier() { }

	private static string ReadIdentifierFromFile() { }

	private static void WriteIdentifierToFile(string identifier) { }

}

