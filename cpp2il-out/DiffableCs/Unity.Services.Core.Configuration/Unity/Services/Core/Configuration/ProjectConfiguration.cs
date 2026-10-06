namespace Unity.Services.Core.Configuration;

internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, ConfigurationEntry>, String> <>9__10_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, ConfigurationEntry>, String> <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <ToJson>b__10_0(KeyValuePair<String, ConfigurationEntry> pair) { }

		internal string <ToJson>b__10_1(KeyValuePair<String, ConfigurationEntry> pair) { }

	}

	private string m_JsonCache; //Field offset: 0x10
	private readonly IReadOnlyDictionary<String, ConfigurationEntry> m_ConfigValues; //Field offset: 0x18
	[CompilerGenerated]
	private readonly IJsonSerializer <Serializer>k__BackingField; //Field offset: 0x20

	internal IJsonSerializer Serializer
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public ProjectConfiguration(IReadOnlyDictionary<String, ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	[CompilerGenerated]
	internal IJsonSerializer get_Serializer() { }

	public override bool GetBool(string key, bool defaultValue = false) { }

	public override float GetFloat(string key, float defaultValue = 0) { }

	public override int GetInt(string key, int defaultValue = 0) { }

	public override string GetString(string key, string defaultValue = null) { }

	public string ToJson() { }

}

