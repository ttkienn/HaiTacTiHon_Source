namespace System.Configuration;

public abstract class ConfigurationSection : ConfigurationElement
{

	protected private override void DeserializeSection(XmlReader reader) { }

	protected private virtual bool IsModified() { }

	protected private virtual void ResetModified() { }

	protected private override string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

