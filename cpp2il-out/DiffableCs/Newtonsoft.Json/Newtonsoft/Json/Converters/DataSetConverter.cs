namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class DataSetConverter : JsonConverter
{

	public DataSetConverter() { }

	public virtual bool CanConvert(Type valueType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

