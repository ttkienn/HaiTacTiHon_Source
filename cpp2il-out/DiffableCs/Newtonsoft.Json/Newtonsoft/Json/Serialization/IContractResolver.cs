namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface IContractResolver
{

	public JsonContract ResolveContract(Type type) { }

}

