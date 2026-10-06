namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public class JsonSchemaGenerator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <GenerateInternal>b__0(TypeSchema tc) { }

	}

	private class TypeSchema
	{
		[CompilerGenerated]
		private readonly Type <Type>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly JsonSchema <Schema>k__BackingField; //Field offset: 0x18

		public JsonSchema Schema
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public Type Type
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public TypeSchema(Type type, JsonSchema schema) { }

		[CompilerGenerated]
		public JsonSchema get_Schema() { }

		[CompilerGenerated]
		public Type get_Type() { }

	}

	[CompilerGenerated]
	private UndefinedSchemaIdHandling <UndefinedSchemaIdHandling>k__BackingField; //Field offset: 0x10
	private IContractResolver _contractResolver; //Field offset: 0x18
	private JsonSchemaResolver _resolver; //Field offset: 0x20
	private readonly IList<TypeSchema> _stack; //Field offset: 0x28
	private JsonSchema _currentSchema; //Field offset: 0x30

	public IContractResolver ContractResolver
	{
		 get { } //Length: 147
		 set { } //Length: 13
	}

	private JsonSchema CurrentSchema
	{
		private get { } //Length: 5
	}

	public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
	{
		[CompilerGenerated]
		 get { } //Length: 191
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public JsonSchemaGenerator() { }

	private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired) { }

	public JsonSchema Generate(Type type, bool rootSchemaNullable) { }

	public JsonSchema Generate(Type type, JsonSchemaResolver resolver) { }

	public JsonSchema Generate(Type type) { }

	public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable) { }

	private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required) { }

	private void GenerateISerializableContract(Type type, JsonISerializableContract contract) { }

	private void GenerateObjectSchema(Type type, JsonObjectContract contract) { }

	public IContractResolver get_ContractResolver() { }

	private JsonSchema get_CurrentSchema() { }

	[CompilerGenerated]
	public UndefinedSchemaIdHandling get_UndefinedSchemaIdHandling() { }

	private string GetDescription(Type type) { }

	private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired) { }

	private string GetTitle(Type type) { }

	private string GetTypeId(Type type, bool explicitOnly) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	internal static bool HasFlag(Nullable<JsonSchemaType> value, JsonSchemaType flag) { }

	private TypeSchema Pop() { }

	private void Push(TypeSchema typeSchema) { }

	public void set_ContractResolver(IContractResolver value) { }

	[CompilerGenerated]
	public void set_UndefinedSchemaIdHandling(UndefinedSchemaIdHandling value) { }

}

