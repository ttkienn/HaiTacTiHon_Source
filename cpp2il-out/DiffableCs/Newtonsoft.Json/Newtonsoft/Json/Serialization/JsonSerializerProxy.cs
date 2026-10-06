namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerProxy : JsonSerializer
{
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; //Field offset: 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; //Field offset: 0xE8
	internal readonly JsonSerializer _serializer; //Field offset: 0xF0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public virtual event EventHandler<ErrorEventArgs> Error
	{
		 add { } //Length: 45
		 remove { } //Length: 45
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public virtual SerializationBinder Binder
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual bool CheckAdditionalContent
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual ConstructorHandling ConstructorHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual StreamingContext Context
	{
		 get { } //Length: 65
		 set { } //Length: 58
	}

	public virtual IContractResolver ContractResolver
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual JsonConverterCollection Converters
	{
		 get { } //Length: 45
	}

	public virtual CultureInfo Culture
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual DateFormatHandling DateFormatHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual string DateFormatString
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual DateParseHandling DateParseHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer
	{
		[NullableContext(2)]
		 get { } //Length: 45
		[NullableContext(2)]
		 set { } //Length: 45
	}

	public virtual FloatFormatHandling FloatFormatHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual FloatParseHandling FloatParseHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual Formatting Formatting
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual Nullable<Int32> MaxDepth
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual MissingMemberHandling MissingMemberHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual NullValueHandling NullValueHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual PreserveReferencesHandling PreserveReferencesHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver
	{
		[NullableContext(2)]
		 get { } //Length: 45
		[NullableContext(2)]
		 set { } //Length: 45
	}

	public virtual ISerializationBinder SerializationBinder
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual StringEscapeHandling StringEscapeHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	[Nullable(2)]
	public virtual ITraceWriter TraceWriter
	{
		[NullableContext(2)]
		 get { } //Length: 45
		[NullableContext(2)]
		 set { } //Length: 45
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public virtual TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 45
		 set { } //Length: 45
	}

	public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter) { }

	public JsonSerializerProxy(JsonSerializerInternalReader serializerReader) { }

	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	public virtual SerializationBinder get_Binder() { }

	public virtual bool get_CheckAdditionalContent() { }

	public virtual ConstructorHandling get_ConstructorHandling() { }

	public virtual StreamingContext get_Context() { }

	public virtual IContractResolver get_ContractResolver() { }

	public virtual JsonConverterCollection get_Converters() { }

	public virtual CultureInfo get_Culture() { }

	public virtual DateFormatHandling get_DateFormatHandling() { }

	public virtual string get_DateFormatString() { }

	public virtual DateParseHandling get_DateParseHandling() { }

	public virtual DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public virtual DefaultValueHandling get_DefaultValueHandling() { }

	[NullableContext(2)]
	public virtual IEqualityComparer get_EqualityComparer() { }

	public virtual FloatFormatHandling get_FloatFormatHandling() { }

	public virtual FloatParseHandling get_FloatParseHandling() { }

	public virtual Formatting get_Formatting() { }

	public virtual Nullable<Int32> get_MaxDepth() { }

	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public virtual MissingMemberHandling get_MissingMemberHandling() { }

	public virtual NullValueHandling get_NullValueHandling() { }

	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	public virtual PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public virtual ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[NullableContext(2)]
	public virtual IReferenceResolver get_ReferenceResolver() { }

	public virtual ISerializationBinder get_SerializationBinder() { }

	public virtual StringEscapeHandling get_StringEscapeHandling() { }

	[NullableContext(2)]
	public virtual ITraceWriter get_TraceWriter() { }

	public virtual FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	public virtual TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	public virtual TypeNameHandling get_TypeNameHandling() { }

	internal JsonSerializerInternalBase GetInternalSerializer() { }

	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

	public virtual void set_Binder(SerializationBinder value) { }

	public virtual void set_CheckAdditionalContent(bool value) { }

	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	public virtual void set_Context(StreamingContext value) { }

	public virtual void set_ContractResolver(IContractResolver value) { }

	public virtual void set_Culture(CultureInfo value) { }

	public virtual void set_DateFormatHandling(DateFormatHandling value) { }

	public virtual void set_DateFormatString(string value) { }

	public virtual void set_DateParseHandling(DateParseHandling value) { }

	public virtual void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(2)]
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	public virtual void set_FloatFormatHandling(FloatFormatHandling value) { }

	public virtual void set_FloatParseHandling(FloatParseHandling value) { }

	public virtual void set_Formatting(Formatting value) { }

	public virtual void set_MaxDepth(Nullable<Int32> value) { }

	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	public virtual void set_NullValueHandling(NullValueHandling value) { }

	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[NullableContext(2)]
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	public virtual void set_StringEscapeHandling(StringEscapeHandling value) { }

	[NullableContext(2)]
	public virtual void set_TraceWriter(ITraceWriter value) { }

	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

}

