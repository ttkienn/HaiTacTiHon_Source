namespace Unity.Services.Core.Configuration.Internal;

public interface IProjectConfiguration : IServiceComponent
{

	public bool GetBool(string key, bool defaultValue = false) { }

	public float GetFloat(string key, float defaultValue = 0) { }

	public int GetInt(string key, int defaultValue = 0) { }

	public string GetString(string key, string defaultValue = null) { }

}

