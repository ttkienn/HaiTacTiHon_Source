namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNode
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JsonSchema, String> <>9__26_0; //Field offset: 0x8
		public static Func<String, String> <>9__26_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <GetId>b__26_0(JsonSchema s) { }

		internal string <GetId>b__26_1(string id) { }

	}

	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<JsonSchema> <Schemas>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Dictionary<String, JsonSchemaNode> <Properties>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Dictionary<String, JsonSchemaNode> <PatternProperties>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly List<JsonSchemaNode> <Items>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalProperties>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private JsonSchemaNode <AdditionalItems>k__BackingField; //Field offset: 0x40

	public JsonSchemaNode AdditionalItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public JsonSchemaNode AdditionalProperties
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public List<JsonSchemaNode> Items
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Dictionary<String, JsonSchemaNode> PatternProperties
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Dictionary<String, JsonSchemaNode> Properties
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ReadOnlyCollection<JsonSchema> Schemas
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public JsonSchemaNode(JsonSchema schema) { }

	private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema) { }

	public JsonSchemaNode Combine(JsonSchema schema) { }

	[CompilerGenerated]
	public JsonSchemaNode get_AdditionalItems() { }

	[CompilerGenerated]
	public JsonSchemaNode get_AdditionalProperties() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public List<JsonSchemaNode> get_Items() { }

	[CompilerGenerated]
	public Dictionary<String, JsonSchemaNode> get_PatternProperties() { }

	[CompilerGenerated]
	public Dictionary<String, JsonSchemaNode> get_Properties() { }

	[CompilerGenerated]
	public ReadOnlyCollection<JsonSchema> get_Schemas() { }

	public static string GetId(IEnumerable<JsonSchema> schemata) { }

	[CompilerGenerated]
	public void set_AdditionalItems(JsonSchemaNode value) { }

	[CompilerGenerated]
	public void set_AdditionalProperties(JsonSchemaNode value) { }

}

