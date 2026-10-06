namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class EntityKeyMemberConverter : JsonConverter
{
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember"; //Field offset: 0x0
	private const string KeyPropertyName = "Key"; //Field offset: 0x0
	private const string TypePropertyName = "Type"; //Field offset: 0x0
	private const string ValuePropertyName = "Value"; //Field offset: 0x0
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; //Field offset: 0x0

	public EntityKeyMemberConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static void EnsureReflectionObject(Type objectType) { }

	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

