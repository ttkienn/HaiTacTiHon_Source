namespace Newtonsoft.Json.Serialization;

[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
[NullableContext(1)]
public class JsonPropertyCollection : KeyedCollection<String, JsonProperty>
{
	private readonly Type _type; //Field offset: 0x30
	private readonly List<JsonProperty> _list; //Field offset: 0x38

	public JsonPropertyCollection(Type type) { }

	public void AddProperty(JsonProperty property) { }

	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	protected virtual string GetKeyForItem(JsonProperty item) { }

	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

	private bool TryGetProperty(string key, out JsonProperty item) { }

}

