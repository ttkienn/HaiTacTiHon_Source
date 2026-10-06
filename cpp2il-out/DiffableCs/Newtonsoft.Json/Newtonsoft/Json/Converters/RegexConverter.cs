namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class RegexConverter : JsonConverter
{
	private const string PatternName = "Pattern"; //Field offset: 0x0
	private const string OptionsName = "Options"; //Field offset: 0x0

	public RegexConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	private bool IsRegex(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	private object ReadRegexString(JsonReader reader) { }

	private void WriteBson(BsonWriter writer, Regex regex) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

}

