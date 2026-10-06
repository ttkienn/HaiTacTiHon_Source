namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
public sealed class JsonDictionaryAttribute : JsonContainerAttribute
{

	public JsonDictionaryAttribute() { }

	[NullableContext(1)]
	public JsonDictionaryAttribute(string id) { }

}

