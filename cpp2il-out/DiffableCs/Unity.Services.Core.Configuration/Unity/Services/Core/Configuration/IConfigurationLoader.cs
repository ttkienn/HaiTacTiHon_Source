namespace Unity.Services.Core.Configuration;

internal interface IConfigurationLoader
{

	public Task<SerializableProjectConfiguration> GetConfigAsync() { }

}

