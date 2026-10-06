namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class ExpandoObjectConverter : JsonConverter
{

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	public ExpandoObjectConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual bool get_CanWrite() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private object ReadList(JsonReader reader) { }

	private object ReadObject(JsonReader reader) { }

	private object ReadValue(JsonReader reader) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

