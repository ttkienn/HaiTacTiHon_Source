namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class ValidationEventArgs : EventArgs
{
	private readonly JsonSchemaException _ex; //Field offset: 0x10

	public JsonSchemaException Exception
	{
		 get { } //Length: 5
	}

	public string Message
	{
		 get { } //Length: 42
	}

	public string Path
	{
		 get { } //Length: 339
	}

	internal ValidationEventArgs(JsonSchemaException ex) { }

	public JsonSchemaException get_Exception() { }

	public string get_Message() { }

	public string get_Path() { }

}

