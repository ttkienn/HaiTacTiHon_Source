namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class KeyValuePairConverter : JsonConverter
{
	private const string KeyName = "Key"; //Field offset: 0x0
	private const string ValueName = "Value"; //Field offset: 0x0
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; //Field offset: 0x0

	private static KeyValuePairConverter() { }

	public KeyValuePairConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static ReflectionObject InitializeReflectionObject(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

