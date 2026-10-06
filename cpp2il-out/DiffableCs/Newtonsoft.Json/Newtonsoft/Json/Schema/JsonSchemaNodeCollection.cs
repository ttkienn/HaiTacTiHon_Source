namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaNodeCollection : KeyedCollection<String, JsonSchemaNode>
{

	public JsonSchemaNodeCollection() { }

	protected virtual string GetKeyForItem(JsonSchemaNode item) { }

}

