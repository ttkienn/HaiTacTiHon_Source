namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
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

	public string Path
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public JsonSchemaException() { }

	public JsonSchemaException(string message) { }

	public JsonSchemaException(string message, Exception innerException) { }

	public JsonSchemaException(SerializationInfo info, StreamingContext context) { }

	internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	[CompilerGenerated]
	public int get_LineNumber() { }

	[CompilerGenerated]
	public int get_LinePosition() { }

	[CompilerGenerated]
	public string get_Path() { }

}

