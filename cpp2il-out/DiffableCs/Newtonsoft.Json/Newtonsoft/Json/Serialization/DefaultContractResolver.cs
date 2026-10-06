namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class DefaultContractResolver : IContractResolver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<MemberInfo, Boolean> <>9__40_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<MemberInfo, Boolean> <>9__40_1; //Field offset: 0x10
		[Nullable(0)]
		public static Func<Type, IEnumerable`1<MemberInfo>> <>9__44_0; //Field offset: 0x18
		[Nullable(0)]
		public static Func<MemberInfo, Boolean> <>9__44_1; //Field offset: 0x20
		[Nullable(0)]
		public static Func<ConstructorInfo, Boolean> <>9__47_0; //Field offset: 0x28
		[Nullable(0)]
		public static Func<JsonProperty, Int32> <>9__75_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal int <CreateProperties>b__75_0(JsonProperty p) { }

		[NullableContext(0)]
		internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

		[NullableContext(0)]
		internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

		[NullableContext(0)]
		internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

		[NullableContext(0)]
		internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

		[NullableContext(0)]
		internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		[Nullable(0)]
		public NamingStrategy namingStrategy; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal string <CreateObjectContract>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2}])]
		public Func<Object, Object> getExtensionDataDictionary; //Field offset: 0x10
		[Nullable(0)]
		public MemberInfo member; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_1
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2}])]
		public Action<Object, Object> setExtensionDataDictionary; //Field offset: 0x10
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public Func<Object> createExtensionDataDictionary; //Field offset: 0x18
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2}])]
		public MethodCall<Object, Object> setExtensionDataDictionaryValue; //Field offset: 0x20
		[Nullable(0)]
		public <>c__DisplayClass45_0 CS$<>8__locals1; //Field offset: 0x28

		public <>c__DisplayClass45_1() { }

		internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_2
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public ObjectConstructor<Object> createEnumerableWrapper; //Field offset: 0x10
		[Nullable(0)]
		public <>c__DisplayClass45_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass45_2() { }

		internal IEnumerable<KeyValuePair`2<Object, Object>> <SetExtensionDataDelegates>b__1(object o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		[Nullable(0)]
		public NamingStrategy namingStrategy; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal string <CreateDictionaryContract>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		[Nullable(0)]
		public NamingStrategy namingStrategy; //Field offset: 0x10

		public <>c__DisplayClass67_0() { }

		internal string <CreateDynamicContract>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2}])]
		public MethodCall<Object, Object> shouldSerializeCall; //Field offset: 0x10

		public <>c__DisplayClass80_0() { }

		internal bool <CreateShouldSerializeTest>b__0(object o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		public Func<Object, Object> specifiedPropertyGet; //Field offset: 0x10

		public <>c__DisplayClass81_0() { }

		internal bool <SetIsSpecifiedActions>b__0(object o) { }

	}

	[NullableContext(0)]
	public class EnumerableDictionaryWrapper : IEnumerable<KeyValuePair`2<Object, Object>>, IEnumerable
	{
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__2 : IEnumerator<KeyValuePair`2<Object, Object>>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x0
			[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
			private KeyValuePair<Object, Object> <>2__current; //Field offset: 0x0
			public EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this; //Field offset: 0x0
			[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 1}])]
			private IEnumerator<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1; //Field offset: 0x0

			private override KeyValuePair<Object, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 11
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 69
			}

			[DebuggerHidden]
			public <GetEnumerator>d__2(int <>1__state) { }

			private void <>m__Finally1() { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override KeyValuePair<Object, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 1}])]
		private readonly IEnumerable<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> _e; //Field offset: 0x0

		public EnumerableDictionaryWrapper`2(IEnumerable<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> e) { }

		[IteratorStateMachine(typeof(<GetEnumerator>d__2))]
		public override IEnumerator<KeyValuePair`2<Object, Object>> GetEnumerator() { }

		[NullableContext(1)]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	private static readonly IContractResolver _instance; //Field offset: 0x0
	private static readonly String[] BlacklistedTypeNames; //Field offset: 0x8
	private static readonly JsonConverter[] BuiltInConverters; //Field offset: 0x10
	private readonly DefaultJsonNameTable _nameTable; //Field offset: 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; //Field offset: 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; //Field offset: 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(2)]
	private NamingStrategy <NamingStrategy>k__BackingField; //Field offset: 0x30

	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool DynamicCodeGeneration
	{
		 get { } //Length: 64
	}

	public bool IgnoreIsSpecifiedMembers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IgnoreSerializableAttribute
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IgnoreSerializableInterface
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IgnoreShouldSerializeMembers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal static IContractResolver Instance
	{
		internal get { } //Length: 78
	}

	[Nullable(2)]
	public NamingStrategy NamingStrategy
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		 set { } //Length: 13
	}

	public bool SerializeCompilerGeneratedMembers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static DefaultContractResolver() { }

	public DefaultContractResolver() { }

	internal static bool CanConvertToString(Type type) { }

	protected override JsonArrayContract CreateArrayContract(Type objectType) { }

	protected override IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	protected override JsonContract CreateContract(Type objectType) { }

	protected override JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	protected override JsonDynamicContract CreateDynamicContract(Type objectType) { }

	protected override JsonISerializableContract CreateISerializableContract(Type objectType) { }

	protected override JsonLinqContract CreateLinqContract(Type objectType) { }

	protected override IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	protected override JsonObjectContract CreateObjectContract(Type objectType) { }

	protected override JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	protected override JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	private Predicate<Object> CreateShouldSerializeTest(MemberInfo member) { }

	protected override JsonStringContract CreateStringContract(Type objectType) { }

	private static bool FilterMembers(MemberInfo member) { }

	[CompilerGenerated]
	public BindingFlags get_DefaultMembersSearchFlags() { }

	public bool get_DynamicCodeGeneration() { }

	[CompilerGenerated]
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CompilerGenerated]
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGenerated]
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGenerated]
	public bool get_IgnoreShouldSerializeMembers() { }

	internal static IContractResolver get_Instance() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public NamingStrategy get_NamingStrategy() { }

	[CompilerGenerated]
	public bool get_SerializeCompilerGeneratedMembers() { }

	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback>& onSerializing, out List<SerializationCallback>& onSerialized, out List<SerializationCallback>& onDeserializing, out List<SerializationCallback>& onDeserialized, out List<SerializationErrorCallback>& onError) { }

	private List<Type> GetClassHierarchyForType(Type type) { }

	internal static string GetClrTypeFullName(Type type) { }

	private Func<Object> GetDefaultCreator(Type createdType) { }

	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	internal override DefaultJsonNameTable GetNameTable() { }

	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	public string GetResolvedPropertyName(string propertyName) { }

	protected override List<MemberInfo> GetSerializableMembers(Type objectType) { }

	private void InitializeContract(JsonContract contract) { }

	private static bool IsConcurrentOrObservableCollection(Type t) { }

	internal static bool IsIConvertible(Type t) { }

	internal static bool IsJsonPrimitiveType(Type t) { }

	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	public override JsonContract ResolveContract(Type type) { }

	protected override JsonConverter ResolveContractConverter(Type objectType) { }

	protected override string ResolveDictionaryKey(string dictionaryKey) { }

	protected override string ResolveExtensionDataName(string extensionDataName) { }

	protected override string ResolvePropertyName(string propertyName) { }

	[CompilerGenerated]
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGenerated]
	public void set_IgnoreIsSpecifiedMembers(bool value) { }

	[CompilerGenerated]
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CompilerGenerated]
	public void set_IgnoreSerializableInterface(bool value) { }

	[CompilerGenerated]
	public void set_IgnoreShouldSerializeMembers(bool value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	public void set_NamingStrategy(NamingStrategy value) { }

	[CompilerGenerated]
	public void set_SerializeCompilerGeneratedMembers(bool value) { }

	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	private static bool ShouldSkipDeserialized(Type t) { }

	private static bool ShouldSkipSerializing(Type t) { }

	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

}

