namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class DataTableConverter : JsonConverter
{

	public DataTableConverter() { }

	public virtual bool CanConvert(Type valueType) { }

	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	private static Type GetColumnDataType(JsonReader reader) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

