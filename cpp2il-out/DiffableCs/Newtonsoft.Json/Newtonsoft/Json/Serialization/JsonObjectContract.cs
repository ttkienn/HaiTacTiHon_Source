namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(2)]
public class JsonObjectContract : JsonContainerContract
{
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	[Nullable(1)]
	private readonly JsonPropertyCollection <Properties>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Func<String, String> <ExtensionDataNameResolver>k__BackingField; //Field offset: 0xF8
	internal bool ExtensionDataIsJToken; //Field offset: 0x100
	private Nullable<Boolean> _hasRequiredOrDefaultValueProperties; //Field offset: 0x101
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private ObjectConstructor<Object> _overrideCreator; //Field offset: 0x108
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private ObjectConstructor<Object> _parameterizedCreator; //Field offset: 0x110
	private JsonPropertyCollection _creatorParameters; //Field offset: 0x118
	private Type _extensionDataValueType; //Field offset: 0x120

	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters
	{
		[NullableContext(1)]
		 get { } //Length: 135
	}

	public ExtensionDataGetter ExtensionDataGetter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public Func<String, String> ExtensionDataNameResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public ExtensionDataSetter ExtensionDataSetter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public Type ExtensionDataValueType
	{
		 get { } //Length: 8
		 set { } //Length: 229
	}

	internal bool HasRequiredOrDefaultValueProperties
	{
		internal get { } //Length: 719
	}

	public Nullable<NullValueHandling> ItemNullValueHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<Required> ItemRequired
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public MemberSerialization MemberSerialization
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Nullable<MissingMemberHandling> MissingMemberHandling
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public ObjectConstructor<Object> OverrideCreator
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	internal ObjectConstructor<Object> ParameterizedCreator
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	[Nullable(1)]
	public JsonPropertyCollection Properties
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
	}

	[NullableContext(1)]
	public JsonObjectContract(Type underlyingType) { }

	[NullableContext(1)]
	public JsonPropertyCollection get_CreatorParameters() { }

	[CompilerGenerated]
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	public Func<String, String> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	public Type get_ExtensionDataValueType() { }

	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[CompilerGenerated]
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	public ObjectConstructor<Object> get_OverrideCreator() { }

	internal ObjectConstructor<Object> get_ParameterizedCreator() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	internal object GetUninitializedObject() { }

	[CompilerGenerated]
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	[CompilerGenerated]
	public void set_ExtensionDataNameResolver(Func<String, String> value) { }

	[CompilerGenerated]
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	public void set_OverrideCreator(ObjectConstructor<Object> value) { }

	internal void set_ParameterizedCreator(ObjectConstructor<Object> value) { }

}

