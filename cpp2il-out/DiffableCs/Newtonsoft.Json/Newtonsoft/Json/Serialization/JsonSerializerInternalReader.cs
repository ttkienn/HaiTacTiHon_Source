namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerInternalReader : JsonSerializerInternalBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<JsonProperty, String> <>9__38_0; //Field offset: 0x8
		[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1}])]
		public static Func<JsonProperty, String> <>9__38_2; //Field offset: 0x10
		[Nullable(0)]
		public static Func<JsonProperty, JsonProperty> <>9__42_0; //Field offset: 0x18
		[Nullable(0)]
		public static Func<JsonProperty, PropertyPresence> <>9__42_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

		[NullableContext(0)]
		internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

		[NullableContext(0)]
		internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

		[NullableContext(0)]
		internal PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		[Nullable(0)]
		public JsonProperty property; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		[NullableContext(0)]
		internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p) { }

	}

	[Nullable(0)]
	[NullableContext(2)]
	public class CreatorPropertyContext
	{
		[Nullable(1)]
		public readonly string Name; //Field offset: 0x10
		public JsonProperty Property; //Field offset: 0x18
		public JsonProperty ConstructorProperty; //Field offset: 0x20
		public Nullable<PropertyPresence> Presence; //Field offset: 0x28
		public object Value; //Field offset: 0x30
		public bool Used; //Field offset: 0x38

		[NullableContext(1)]
		public CreatorPropertyContext(string name) { }

	}

	[NullableContext(0)]
	public enum PropertyPresence
	{
		None = 0,
		Null = 1,
		Value = 2,
	}


	public JsonSerializerInternalReader(JsonSerializer serializer) { }

	private void AddReference(JsonReader reader, string id, object value) { }

	[NullableContext(2)]
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	[NullableContext(2)]
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	private JToken CreateJObject(JsonReader reader) { }

	[NullableContext(2)]
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	[NullableContext(2)]
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	[NullableContext(2)]
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<Object> creator, string id) { }

	[NullableContext(2)]
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue) { }

	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[NullableContext(2)]
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	private JsonContract GetContract(Type type) { }

	[NullableContext(2)]
	private JsonContract GetContractSafe(Type type) { }

	[NullableContext(2)]
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	internal string GetExpectedDescription(JsonContract contract) { }

	private JsonSerializerProxy GetInternalSerializer() { }

	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[NullableContext(2)]
	private bool HasNoDefinedType(JsonContract contract) { }

	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	public void Populate(JsonReader reader, object target) { }

	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	[NullableContext(2)]
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties) { }

	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	[NullableContext(2)]
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

}

