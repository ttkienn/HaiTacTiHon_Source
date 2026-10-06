namespace Newtonsoft.Json.Serialization;

public class CamelCaseNamingStrategy : NamingStrategy
{

	public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	public CamelCaseNamingStrategy() { }

	[NullableContext(1)]
	protected virtual string ResolvePropertyName(string name) { }

}

