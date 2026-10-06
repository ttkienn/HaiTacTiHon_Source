namespace System.Configuration;

public sealed class IgnoreSection : ConfigurationSection
{

	protected private virtual ConfigurationPropertyCollection Properties
	{
		private get { } //Length: 44
	}

	public IgnoreSection() { }

	protected private virtual void DeserializeSection(XmlReader xmlReader) { }

	protected private virtual ConfigurationPropertyCollection get_Properties() { }

	protected private virtual bool IsModified() { }

	protected private virtual void Reset(ConfigurationElement parentSection) { }

	protected private virtual void ResetModified() { }

	protected private virtual string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

