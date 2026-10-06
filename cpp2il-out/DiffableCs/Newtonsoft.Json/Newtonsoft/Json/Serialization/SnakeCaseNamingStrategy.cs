namespace Newtonsoft.Json.Serialization;

public class SnakeCaseNamingStrategy : NamingStrategy
{

	public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	public SnakeCaseNamingStrategy() { }

	[NullableContext(1)]
	protected virtual string ResolvePropertyName(string name) { }

}

