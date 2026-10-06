namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonSerializer
{
	internal TypeNameHandling _typeNameHandling; //Field offset: 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; //Field offset: 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; //Field offset: 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; //Field offset: 0x1C
	internal MissingMemberHandling _missingMemberHandling; //Field offset: 0x20
	internal ObjectCreationHandling _objectCreationHandling; //Field offset: 0x24
	internal NullValueHandling _nullValueHandling; //Field offset: 0x28
	internal DefaultValueHandling _defaultValueHandling; //Field offset: 0x2C
	internal ConstructorHandling _constructorHandling; //Field offset: 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; //Field offset: 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; //Field offset: 0x38
	internal IContractResolver _contractResolver; //Field offset: 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; //Field offset: 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; //Field offset: 0x50
	internal ISerializationBinder _serializationBinder; //Field offset: 0x58
	internal StreamingContext _context; //Field offset: 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; //Field offset: 0x70
	private Nullable<Formatting> _formatting; //Field offset: 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x88
	private Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0xA8
	private CultureInfo _culture; //Field offset: 0xB0
	private Nullable<Int32> _maxDepth; //Field offset: 0xB8
	private bool _maxDepthSet; //Field offset: 0xC0
	private Nullable<Boolean> _checkAdditionalContent; //Field offset: 0xC1
	[Nullable(2)]
	private string _dateFormatString; //Field offset: 0xC8
	private bool _dateFormatStringSet; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private EventHandler<ErrorEventArgs> Error; //Field offset: 0xD8

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event EventHandler<ErrorEventArgs> Error
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public override SerializationBinder Binder
	{
		 get { } //Length: 269
		 set { } //Length: 250
	}

	public override bool CheckAdditionalContent
	{
		 get { } //Length: 63
		 set { } //Length: 94
	}

	public override ConstructorHandling ConstructorHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override StreamingContext Context
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public override IContractResolver ContractResolver
	{
		 get { } //Length: 5
		 set { } //Length: 171
	}

	public override JsonConverterCollection Converters
	{
		 get { } //Length: 138
	}

	public override CultureInfo Culture
	{
		 get { } //Length: 97
		 set { } //Length: 19
	}

	public override DateFormatHandling DateFormatHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public override string DateFormatString
	{
		 get { } //Length: 64
		 set { } //Length: 41
	}

	public override DateParseHandling DateParseHandling
	{
		 get { } //Length: 81
		 set { } //Length: 94
	}

	public override DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 81
		 set { } //Length: 94
	}

	public override DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	[Nullable(2)]
	public override IEqualityComparer EqualityComparer
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public override FloatFormatHandling FloatFormatHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public override FloatParseHandling FloatParseHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public override Formatting Formatting
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public override Nullable<Int32> MaxDepth
	{
		 get { } //Length: 8
		 set { } //Length: 187
	}

	public override MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override MissingMemberHandling MissingMemberHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override NullValueHandling NullValueHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override PreserveReferencesHandling PreserveReferencesHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver
	{
		[NullableContext(2)]
		 get { } //Length: 105
		[NullableContext(2)]
		 set { } //Length: 136
	}

	public override ISerializationBinder SerializationBinder
	{
		 get { } //Length: 5
		 set { } //Length: 136
	}

	public override StringEscapeHandling StringEscapeHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	[Nullable(2)]
	public override ITraceWriter TraceWriter
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 13
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public override FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 191
		 set { } //Length: 99
	}

	public JsonSerializer() { }

	[CompilerGenerated]
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	public static JsonSerializer Create() { }

	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	public static JsonSerializer CreateDefault() { }

	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public T Deserialize(JsonReader reader) { }

	[DebuggerStepThrough]
	public object Deserialize(JsonReader reader) { }

	[DebuggerStepThrough]
	public object Deserialize(TextReader reader, Type objectType) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public object Deserialize(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	public override SerializationBinder get_Binder() { }

	public override bool get_CheckAdditionalContent() { }

	public override ConstructorHandling get_ConstructorHandling() { }

	public override StreamingContext get_Context() { }

	public override IContractResolver get_ContractResolver() { }

	public override JsonConverterCollection get_Converters() { }

	public override CultureInfo get_Culture() { }

	public override DateFormatHandling get_DateFormatHandling() { }

	public override string get_DateFormatString() { }

	public override DateParseHandling get_DateParseHandling() { }

	public override DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public override DefaultValueHandling get_DefaultValueHandling() { }

	[NullableContext(2)]
	public override IEqualityComparer get_EqualityComparer() { }

	public override FloatFormatHandling get_FloatFormatHandling() { }

	public override FloatParseHandling get_FloatParseHandling() { }

	public override Formatting get_Formatting() { }

	public override Nullable<Int32> get_MaxDepth() { }

	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public override MissingMemberHandling get_MissingMemberHandling() { }

	public override NullValueHandling get_NullValueHandling() { }

	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	public override PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public override ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[NullableContext(2)]
	public override IReferenceResolver get_ReferenceResolver() { }

	public override ISerializationBinder get_SerializationBinder() { }

	public override StringEscapeHandling get_StringEscapeHandling() { }

	[NullableContext(2)]
	public override ITraceWriter get_TraceWriter() { }

	public override FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	public override TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	public override TypeNameHandling get_TypeNameHandling() { }

	internal JsonConverter GetMatchingConverter(Type type) { }

	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	internal IReferenceResolver GetReferenceResolver() { }

	internal bool IsCheckAdditionalContentSet() { }

	internal void OnError(ErrorEventArgs e) { }

	[DebuggerStepThrough]
	public void Populate(JsonReader reader, object target) { }

	[DebuggerStepThrough]
	public void Populate(TextReader reader, object target) { }

	internal override void PopulateInternal(JsonReader reader, object target) { }

	[CompilerGenerated]
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<Int32> previousMaxDepth, string previousDateFormatString) { }

	public void Serialize(TextWriter textWriter, object value) { }

	[NullableContext(2)]
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	public void Serialize(TextWriter textWriter, object value, Type objectType) { }

	public void Serialize(JsonWriter jsonWriter, object value) { }

	[NullableContext(2)]
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	public override void set_Binder(SerializationBinder value) { }

	public override void set_CheckAdditionalContent(bool value) { }

	public override void set_ConstructorHandling(ConstructorHandling value) { }

	public override void set_Context(StreamingContext value) { }

	public override void set_ContractResolver(IContractResolver value) { }

	public override void set_Culture(CultureInfo value) { }

	public override void set_DateFormatHandling(DateFormatHandling value) { }

	public override void set_DateFormatString(string value) { }

	public override void set_DateParseHandling(DateParseHandling value) { }

	public override void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(2)]
	public override void set_EqualityComparer(IEqualityComparer value) { }

	public override void set_FloatFormatHandling(FloatFormatHandling value) { }

	public override void set_FloatParseHandling(FloatParseHandling value) { }

	public override void set_Formatting(Formatting value) { }

	public override void set_MaxDepth(Nullable<Int32> value) { }

	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	public override void set_NullValueHandling(NullValueHandling value) { }

	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[NullableContext(2)]
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	public override void set_SerializationBinder(ISerializationBinder value) { }

	public override void set_StringEscapeHandling(StringEscapeHandling value) { }

	[NullableContext(2)]
	public override void set_TraceWriter(ITraceWriter value) { }

	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public override void set_TypeNameHandling(TypeNameHandling value) { }

	[NullableContext(2)]
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling>& previousDateTimeZoneHandling, out Nullable<DateParseHandling>& previousDateParseHandling, out Nullable<FloatParseHandling>& previousFloatParseHandling, out Nullable<Int32>& previousMaxDepth, out string previousDateFormatString) { }

}

