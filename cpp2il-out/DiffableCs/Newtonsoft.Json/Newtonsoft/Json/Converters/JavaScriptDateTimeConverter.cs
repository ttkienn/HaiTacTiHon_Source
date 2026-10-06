namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class JavaScriptDateTimeConverter : DateTimeConverterBase
{

	public JavaScriptDateTimeConverter() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

