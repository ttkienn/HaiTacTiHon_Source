namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonException : Exception
{

	public JsonException() { }

	public JsonException(string message) { }

	public JsonException(string message, Exception innerException) { }

	public JsonException(SerializationInfo info, StreamingContext context) { }

	internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message) { }

}

