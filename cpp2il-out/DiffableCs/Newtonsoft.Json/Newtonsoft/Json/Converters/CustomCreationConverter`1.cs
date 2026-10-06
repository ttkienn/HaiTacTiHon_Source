namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public abstract class CustomCreationConverter : JsonConverter
{

	public virtual bool CanWrite
	{
		 get { } //Length: 3
	}

	protected CustomCreationConverter`1() { }

	public virtual bool CanConvert(Type objectType) { }

	public abstract T Create(Type objectType) { }

	public virtual bool get_CanWrite() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

