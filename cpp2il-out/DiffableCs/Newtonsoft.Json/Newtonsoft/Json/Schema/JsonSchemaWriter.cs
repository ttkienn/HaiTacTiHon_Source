namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaWriter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JsonSchemaType, Boolean> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <WriteType>b__7_0(JsonSchemaType v) { }

	}

	private readonly JsonWriter _writer; //Field offset: 0x10
	private readonly JsonSchemaResolver _resolver; //Field offset: 0x18

	public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver) { }

	private void ReferenceOrWriteSchema(JsonSchema schema) { }

	private void WriteItems(JsonSchema schema) { }

	private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value) { }

	public void WriteSchema(JsonSchema schema) { }

	private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<String, JsonSchema> properties) { }

	private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type) { }

}

