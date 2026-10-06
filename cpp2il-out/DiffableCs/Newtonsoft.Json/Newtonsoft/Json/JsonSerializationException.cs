namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonSerializationException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	public int LineNumber
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public int LinePosition
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	[Nullable(2)]
	public string Path
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 8
	}

	public JsonSerializationException() { }

	public JsonSerializationException(string message) { }

	public JsonSerializationException(string message, Exception innerException) { }

	public JsonSerializationException(SerializationInfo info, StreamingContext context) { }

	public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

	[CompilerGenerated]
	public int get_LineNumber() { }

	[CompilerGenerated]
	public int get_LinePosition() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public string get_Path() { }

}

