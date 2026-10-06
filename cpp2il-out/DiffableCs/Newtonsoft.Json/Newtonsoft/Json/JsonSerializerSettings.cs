namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public class JsonSerializerSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		[Nullable(0)]
		public IReferenceResolver value; //Field offset: 0x10

		public <>c__DisplayClass93_0() { }

		internal IReferenceResolver <set_ReferenceResolver>b__0() { }

	}

	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = 0; //Field offset: 0x0
	internal const int DefaultMaxDepth = 64; //Field offset: 0x0
	[Nullable(1)]
	internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"; //Field offset: 0x0
	internal const bool DefaultCheckAdditionalContent = False; //Field offset: 0x0
	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0; //Field offset: 0x0
	internal const StringEscapeHandling DefaultStringEscapeHandling = 0; //Field offset: 0x0
	internal const FloatFormatHandling DefaultFloatFormatHandling = 0; //Field offset: 0x0
	internal const FloatParseHandling DefaultFloatParseHandling = 0; //Field offset: 0x0
	internal const DateParseHandling DefaultDateParseHandling = 1; //Field offset: 0x0
	internal const DateFormatHandling DefaultDateFormatHandling = 0; //Field offset: 0x0
	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = 3; //Field offset: 0x0
	internal static readonly StreamingContext DefaultContext; //Field offset: 0x0
	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = 0; //Field offset: 0x0
	internal const TypeNameHandling DefaultTypeNameHandling = 0; //Field offset: 0x0
	internal const ConstructorHandling DefaultConstructorHandling = 0; //Field offset: 0x0
	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = 0; //Field offset: 0x0
	internal const ObjectCreationHandling DefaultObjectCreationHandling = 0; //Field offset: 0x0
	internal const DefaultValueHandling DefaultDefaultValueHandling = 0; //Field offset: 0x0
	internal const NullValueHandling DefaultNullValueHandling = 0; //Field offset: 0x0
	internal const MissingMemberHandling DefaultMissingMemberHandling = 0; //Field offset: 0x0
	internal const Formatting DefaultFormatting = 0; //Field offset: 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; //Field offset: 0x10
	internal Nullable<Formatting> _formatting; //Field offset: 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0x40
	internal CultureInfo _culture; //Field offset: 0x48
	internal Nullable<Boolean> _checkAdditionalContent; //Field offset: 0x50
	internal Nullable<Int32> _maxDepth; //Field offset: 0x54
	internal bool _maxDepthSet; //Field offset: 0x5C
	internal string _dateFormatString; //Field offset: 0x60
	internal bool _dateFormatStringSet; //Field offset: 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; //Field offset: 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; //Field offset: 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x9C
	internal Nullable<StreamingContext> _context; //Field offset: 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; //Field offset: 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(1)]
	private IList<JsonConverter> <Converters>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; //Field offset: 0x108

	[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
	public SerializationBinder Binder
	{
		 get { } //Length: 206
		 set { } //Length: 135
	}

	public bool CheckAdditionalContent
	{
		 get { } //Length: 57
		 set { } //Length: 91
	}

	public ConstructorHandling ConstructorHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public StreamingContext Context
	{
		 get { } //Length: 182
		 set { } //Length: 140
	}

	public IContractResolver ContractResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	[Nullable(1)]
	public IList<JsonConverter> Converters
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
		[CompilerGenerated]
		[NullableContext(1)]
		 set { } //Length: 19
	}

	[Nullable(1)]
	public CultureInfo Culture
	{
		[NullableContext(1)]
		 get { } //Length: 94
		[NullableContext(1)]
		 set { } //Length: 13
	}

	public DateFormatHandling DateFormatHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	[Nullable(1)]
	public string DateFormatString
	{
		[NullableContext(1)]
		 get { } //Length: 61
		[NullableContext(1)]
		 set { } //Length: 32
	}

	public DateParseHandling DateParseHandling
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public DateTimeZoneHandling DateTimeZoneHandling
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public IEqualityComparer EqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public EventHandler<ErrorEventArgs> Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public FloatFormatHandling FloatFormatHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public FloatParseHandling FloatParseHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public Formatting Formatting
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public Nullable<Int32> MaxDepth
	{
		 get { } //Length: 95
		 set { } //Length: 181
	}

	public MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public MissingMemberHandling MissingMemberHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public NullValueHandling NullValueHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	public PreserveReferencesHandling PreserveReferencesHandling
	{
		 get { } //Length: 61
		 set { } //Length: 91
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
	public IReferenceResolver ReferenceResolver
	{
		 get { } //Length: 30
		 set { } //Length: 213
	}

	public Func<IReferenceResolver> ReferenceResolverProvider
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public ISerializationBinder SerializationBinder
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	public StringEscapeHandling StringEscapeHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public ITraceWriter TraceWriter
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 19
	}

	[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
	public FormatterAssemblyStyle TypeNameAssemblyFormat
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	private static JsonSerializerSettings() { }

	[NullableContext(1)]
	public JsonSerializerSettings(JsonSerializerSettings original) { }

	[DebuggerStepThrough]
	public JsonSerializerSettings() { }

	public SerializationBinder get_Binder() { }

	public bool get_CheckAdditionalContent() { }

	public ConstructorHandling get_ConstructorHandling() { }

	public StreamingContext get_Context() { }

	[CompilerGenerated]
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public IList<JsonConverter> get_Converters() { }

	[NullableContext(1)]
	public CultureInfo get_Culture() { }

	public DateFormatHandling get_DateFormatHandling() { }

	[NullableContext(1)]
	public string get_DateFormatString() { }

	public DateParseHandling get_DateParseHandling() { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGenerated]
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	public EventHandler<ErrorEventArgs> get_Error() { }

	public FloatFormatHandling get_FloatFormatHandling() { }

	public FloatParseHandling get_FloatParseHandling() { }

	public Formatting get_Formatting() { }

	public Nullable<Int32> get_MaxDepth() { }

	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public MissingMemberHandling get_MissingMemberHandling() { }

	public NullValueHandling get_NullValueHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	public IReferenceResolver get_ReferenceResolver() { }

	[CompilerGenerated]
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	public ISerializationBinder get_SerializationBinder() { }

	public StringEscapeHandling get_StringEscapeHandling() { }

	[CompilerGenerated]
	public ITraceWriter get_TraceWriter() { }

	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	public TypeNameHandling get_TypeNameHandling() { }

	public void set_Binder(SerializationBinder value) { }

	public void set_CheckAdditionalContent(bool value) { }

	public void set_ConstructorHandling(ConstructorHandling value) { }

	public void set_Context(StreamingContext value) { }

	[CompilerGenerated]
	public void set_ContractResolver(IContractResolver value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	public void set_Converters(IList<JsonConverter> value) { }

	[NullableContext(1)]
	public void set_Culture(CultureInfo value) { }

	public void set_DateFormatHandling(DateFormatHandling value) { }

	[NullableContext(1)]
	public void set_DateFormatString(string value) { }

	public void set_DateParseHandling(DateParseHandling value) { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[CompilerGenerated]
	public void set_EqualityComparer(IEqualityComparer value) { }

	[CompilerGenerated]
	public void set_Error(EventHandler<ErrorEventArgs> value) { }

	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	public void set_FloatParseHandling(FloatParseHandling value) { }

	public void set_Formatting(Formatting value) { }

	public void set_MaxDepth(Nullable<Int32> value) { }

	public void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public void set_MissingMemberHandling(MissingMemberHandling value) { }

	public void set_NullValueHandling(NullValueHandling value) { }

	public void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public void set_ReferenceResolver(IReferenceResolver value) { }

	[CompilerGenerated]
	public void set_ReferenceResolverProvider(Func<IReferenceResolver> value) { }

	[CompilerGenerated]
	public void set_SerializationBinder(ISerializationBinder value) { }

	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	[CompilerGenerated]
	public void set_TraceWriter(ITraceWriter value) { }

	public void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public void set_TypeNameHandling(TypeNameHandling value) { }

}

