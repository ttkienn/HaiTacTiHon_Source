namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
{
	[Nullable(2)]
	private Type _rootType; //Field offset: 0x38
	private int _rootLevel; //Field offset: 0x40
	private readonly List<Object> _serializeStack; //Field offset: 0x48

	public JsonSerializerInternalWriter(JsonSerializer serializer) { }

	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	[NullableContext(2)]
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private JsonContract GetContract(object value) { }

	[NullableContext(2)]
	private JsonContract GetContractSafe(object value) { }

	private JsonSerializerProxy GetInternalSerializer() { }

	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	private string GetReference(JsonWriter writer, object value) { }

	private void HandleError(JsonWriter writer, int initialDepth) { }

	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	[NullableContext(2)]
	private Nullable<Boolean> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, Int32[] indices) { }

	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	[NullableContext(2)]
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	[NullableContext(2)]
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[NullableContext(2)]
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[NullableContext(2)]
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	internal static bool TryConvertToString(object value, Type type, out string s) { }

	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void WriteReference(JsonWriter writer, object value) { }

	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void WriteTypeProperty(JsonWriter writer, Type type) { }

}

