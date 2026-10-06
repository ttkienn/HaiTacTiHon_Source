namespace Unity.Services.Analytics.Internal;

internal class PlayerPrefsPersistence : IPersistence
{

	public PlayerPrefsPersistence() { }

	public override void ClearValue(string key) { }

	public override int LoadInt(string key) { }

	public override string LoadString(string key) { }

	public override void SaveValue(string key, int value) { }

	public override void SaveValue(string key, string value) { }

}

