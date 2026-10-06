namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
public class BinaryConverter : JsonConverter
{
	private const string BinaryTypeName = "System.Data.Linq.Binary"; //Field offset: 0x0
	private const string BinaryToArrayName = "ToArray"; //Field offset: 0x0
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; //Field offset: 0x0

	public BinaryConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static void EnsureReflectionObject(Type t) { }

	private Byte[] GetByteArray(object value) { }

	private Byte[] ReadByteArray(JsonReader reader) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

