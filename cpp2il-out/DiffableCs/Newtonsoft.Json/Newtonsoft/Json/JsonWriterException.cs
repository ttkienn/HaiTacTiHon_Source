namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonWriterException : JsonException
{
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x90

	[Nullable(2)]
	public string Path
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	public JsonWriterException() { }

	public JsonWriterException(string message) { }

	public JsonWriterException(string message, Exception innerException) { }

	public JsonWriterException(SerializationInfo info, StreamingContext context) { }

	public JsonWriterException(string message, string path, Exception innerException) { }

	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	internal static JsonWriterException Create(string path, string message, Exception ex) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public string get_Path() { }

}

