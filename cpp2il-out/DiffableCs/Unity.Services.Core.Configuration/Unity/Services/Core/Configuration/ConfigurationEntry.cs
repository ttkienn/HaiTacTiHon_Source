namespace Unity.Services.Core.Configuration;

internal class ConfigurationEntry
{
	[JsonRequired]
	[SerializeField]
	private string m_Value; //Field offset: 0x10
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly; //Field offset: 0x18

	[JsonIgnore]
	public bool IsReadOnly
	{
		 get { } //Length: 5
	}

	[JsonIgnore]
	public string Value
	{
		 get { } //Length: 5
	}

	public ConfigurationEntry() { }

	public ConfigurationEntry(string value, bool isReadOnly = false) { }

	public bool get_IsReadOnly() { }

	public string get_Value() { }

	public static string op_Implicit(ConfigurationEntry entry) { }

	public static ConfigurationEntry op_Implicit(string value) { }

	public bool TrySetValue(string value) { }

}

