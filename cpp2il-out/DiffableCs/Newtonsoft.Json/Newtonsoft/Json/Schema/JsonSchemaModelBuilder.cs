namespace Newtonsoft.Json.Schema;

[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
internal class JsonSchemaModelBuilder
{
	private JsonSchemaNodeCollection _nodes; //Field offset: 0x10
	private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels; //Field offset: 0x18
	private JsonSchemaNode _node; //Field offset: 0x20

	public JsonSchemaModelBuilder() { }

	public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema) { }

	public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema) { }

	public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema) { }

	public void AddProperties(IDictionary<String, JsonSchema> source, IDictionary<String, JsonSchemaNode> target) { }

	public void AddProperty(IDictionary<String, JsonSchemaNode> target, string propertyName, JsonSchema schema) { }

	public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema) { }

	public JsonSchemaModel Build(JsonSchema schema) { }

	private JsonSchemaModel BuildNodeModel(JsonSchemaNode node) { }

}

