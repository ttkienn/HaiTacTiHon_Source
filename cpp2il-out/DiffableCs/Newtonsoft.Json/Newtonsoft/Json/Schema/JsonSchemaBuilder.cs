namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaBuilder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public JsonSchemaType type; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <MapType>b__0(KeyValuePair<String, JsonSchemaType> kv) { }

	}

	private readonly IList<JsonSchema> _stack; //Field offset: 0x10
	private readonly JsonSchemaResolver _resolver; //Field offset: 0x18
	private readonly IDictionary<String, JsonSchema> _documentSchemas; //Field offset: 0x20
	private JsonSchema _currentSchema; //Field offset: 0x28
	private JObject _rootSchema; //Field offset: 0x30

	private JsonSchema CurrentSchema
	{
		private get { } //Length: 5
	}

	public JsonSchemaBuilder(JsonSchemaResolver resolver) { }

	private JsonSchema BuildSchema(JToken token) { }

	private JsonSchema get_CurrentSchema() { }

	internal static JsonSchemaType MapType(string type) { }

	internal static string MapType(JsonSchemaType type) { }

	private JsonSchema Pop() { }

	private void ProcessAdditionalItems(JToken token) { }

	private void ProcessAdditionalProperties(JToken token) { }

	private void ProcessEnum(JToken token) { }

	private void ProcessExtends(JToken token) { }

	private void ProcessItems(JToken token) { }

	private IDictionary<String, JsonSchema> ProcessProperties(JToken token) { }

	private void ProcessSchemaProperties(JObject schemaObject) { }

	private Nullable<JsonSchemaType> ProcessType(JToken token) { }

	private void Push(JsonSchema value) { }

	internal JsonSchema Read(JsonReader reader) { }

	private JsonSchema ResolveReferences(JsonSchema schema) { }

	private string UnescapeReference(string reference) { }

}

