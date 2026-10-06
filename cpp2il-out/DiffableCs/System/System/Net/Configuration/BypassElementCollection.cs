namespace System.Net.Configuration;

[ConfigurationCollection(typeof(BypassElement))]
[DefaultMember("Item")]
public sealed class BypassElementCollection : ConfigurationElementCollection
{

	public BypassElementCollection() { }

}

