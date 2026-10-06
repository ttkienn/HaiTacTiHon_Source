namespace Newtonsoft.Json.Schema;

[Extension]
[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
public static class Extensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public bool valid; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal void <IsValid>b__0(object sender, ValidationEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public IList<String> errors; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal void <IsValid>b__0(object sender, ValidationEventArgs args) { }

	}


	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool IsValid(JToken source, JsonSchema schema) { }

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static bool IsValid(JToken source, JsonSchema schema, out IList<String>& errorMessages) { }

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void Validate(JToken source, JsonSchema schema) { }

	[Extension]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static void Validate(JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler) { }

}

