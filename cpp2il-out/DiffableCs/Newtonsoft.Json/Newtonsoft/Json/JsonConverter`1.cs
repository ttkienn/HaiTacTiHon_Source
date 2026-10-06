namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonConverter : JsonConverter
{

	protected JsonConverter`1() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public abstract T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	public abstract void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) { }

}

