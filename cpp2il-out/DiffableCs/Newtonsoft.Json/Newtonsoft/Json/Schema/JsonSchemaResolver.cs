namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaResolver
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string reference; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <GetSchema>b__0(JsonSchema s) { }

		internal bool <GetSchema>b__1(JsonSchema s) { }

	}

	[CompilerGenerated]
	private IList<JsonSchema> <LoadedSchemas>k__BackingField; //Field offset: 0x10

	public IList<JsonSchema> LoadedSchemas
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public JsonSchemaResolver() { }

	[CompilerGenerated]
	public IList<JsonSchema> get_LoadedSchemas() { }

	public override JsonSchema GetSchema(string reference) { }

	[CompilerGenerated]
	protected void set_LoadedSchemas(IList<JsonSchema> value) { }

}

