namespace Unity.Services.Analytics.Internal;

internal interface IPersistence
{

	public void ClearValue(string key) { }

	public int LoadInt(string key) { }

	public string LoadString(string key) { }

	public void SaveValue(string key, int value) { }

	public void SaveValue(string key, string value) { }

}

