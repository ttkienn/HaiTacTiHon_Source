namespace Newtonsoft.Json.Serialization;

public class DefaultNamingStrategy : NamingStrategy
{

	public DefaultNamingStrategy() { }

	[NullableContext(1)]
	protected virtual string ResolvePropertyName(string name) { }

}

