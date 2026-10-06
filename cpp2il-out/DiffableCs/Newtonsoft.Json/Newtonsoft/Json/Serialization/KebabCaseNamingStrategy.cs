namespace Newtonsoft.Json.Serialization;

public class KebabCaseNamingStrategy : NamingStrategy
{

	public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	public KebabCaseNamingStrategy() { }

	[NullableContext(1)]
	protected virtual string ResolvePropertyName(string name) { }

}

