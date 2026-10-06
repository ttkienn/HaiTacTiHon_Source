namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class VersionConverter : JsonConverter
{

	public VersionConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

