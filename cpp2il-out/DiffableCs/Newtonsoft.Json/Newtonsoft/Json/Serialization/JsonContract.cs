namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public abstract class JsonContract
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		[Nullable(0)]
		public MethodInfo callbackMethodInfo; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		[Nullable(0)]
		public MethodInfo callbackMethodInfo; //Field offset: 0x10

		public <>c__DisplayClass58_0() { }

		internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

	}

	internal bool IsNullable; //Field offset: 0x10
	internal bool IsConvertable; //Field offset: 0x11
	internal bool IsEnum; //Field offset: 0x12
	internal Type NonNullableUnderlyingType; //Field offset: 0x18
	internal ReadType InternalReadType; //Field offset: 0x20
	internal JsonContractType ContractType; //Field offset: 0x24
	internal bool IsReadOnlyOrFixedSize; //Field offset: 0x28
	internal bool IsSealed; //Field offset: 0x29
	internal bool IsInstantiable; //Field offset: 0x2A
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private List<SerializationCallback> _onDeserializedCallbacks; //Field offset: 0x30
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private List<SerializationCallback> _onDeserializingCallbacks; //Field offset: 0x38
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private List<SerializationCallback> _onSerializedCallbacks; //Field offset: 0x40
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private List<SerializationCallback> _onSerializingCallbacks; //Field offset: 0x48
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private List<SerializationErrorCallback> _onErrorCallbacks; //Field offset: 0x50
	private Type _createdType; //Field offset: 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Nullable<Boolean> <IsReference>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[Nullable(2)]
	private JsonConverter <Converter>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	[Nullable(2)]
	private JsonConverter <InternalConverter>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Func<Object> <DefaultCreator>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; //Field offset: 0x88

	[Nullable(2)]
	public JsonConverter Converter
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public Type CreatedType
	{
		 get { } //Length: 5
		 set { } //Length: 248
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Func<Object> DefaultCreator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public bool DefaultCreatorNonPublic
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[Nullable(2)]
	public internal JsonConverter InternalConverter
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		internal set { } //Length: 13
	}

	public Nullable<Boolean> IsReference
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public IList<SerializationCallback> OnDeserializedCallbacks
	{
		 get { } //Length: 122
	}

	public IList<SerializationCallback> OnDeserializingCallbacks
	{
		 get { } //Length: 122
	}

	public IList<SerializationErrorCallback> OnErrorCallbacks
	{
		 get { } //Length: 122
	}

	public IList<SerializationCallback> OnSerializedCallbacks
	{
		 get { } //Length: 122
	}

	public IList<SerializationCallback> OnSerializingCallbacks
	{
		 get { } //Length: 122
	}

	public Type UnderlyingType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal JsonContract(Type underlyingType) { }

	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public JsonConverter get_Converter() { }

	public Type get_CreatedType() { }

	[CompilerGenerated]
	public Func<Object> get_DefaultCreator() { }

	[CompilerGenerated]
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public JsonConverter get_InternalConverter() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_IsReference() { }

	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	[CompilerGenerated]
	public Type get_UnderlyingType() { }

	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_Converter(JsonConverter value) { }

	public void set_CreatedType(Type value) { }

	[CompilerGenerated]
	public void set_DefaultCreator(Func<Object> value) { }

	[CompilerGenerated]
	public void set_DefaultCreatorNonPublic(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	internal void set_InternalConverter(JsonConverter value) { }

	[CompilerGenerated]
	public void set_IsReference(Nullable<Boolean> value) { }

}

