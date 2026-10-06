namespace Unity.Services.Core.Configuration;

[Extension]
internal static class ConfigurationCollectionHelper
{

	[Extension]
	public static void FillWith(IDictionary<String, ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	[Extension]
	public static void FillWith(IDictionary<String, ConfigurationEntry> self, InitializationOptions options) { }

	[Extension]
	private static void SetOrCreateEntry(IDictionary<String, ConfigurationEntry> self, string key, ConfigurationEntry entry) { }

}

