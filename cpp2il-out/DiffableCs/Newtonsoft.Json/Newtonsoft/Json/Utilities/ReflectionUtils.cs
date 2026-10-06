namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class ReflectionUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<ConstructorInfo, Boolean> <>9__11_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<MemberInfo, String> <>9__31_0; //Field offset: 0x10
		[Nullable(0)]
		public static Func<ParameterInfo, Type> <>9__39_0; //Field offset: 0x18
		[Nullable(0)]
		public static Func<FieldInfo, Boolean> <>9__41_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }

		[NullableContext(0)]
		internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

		[NullableContext(0)]
		internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

		[NullableContext(0)]
		internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		[Nullable(0)]
		public MemberInfo memberInfo; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		[NullableContext(0)]
		internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		[Nullable(0)]
		public PropertyInfo subTypeProperty; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		[NullableContext(0)]
		internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

		[NullableContext(0)]
		internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_1
	{
		[Nullable(0)]
		public Type subTypePropertyDeclaringType; //Field offset: 0x10
		[Nullable(0)]
		public <>c__DisplayClass44_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass44_1() { }

		[NullableContext(0)]
		internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		[Nullable(0)]
		public string method; //Field offset: 0x10
		[Nullable(0)]
		public Type methodDeclaringType; //Field offset: 0x18

		public <>c__DisplayClass45_0() { }

		[NullableContext(0)]
		internal bool <IsMethodOverridden>b__0(MethodInfo info) { }

	}

	public static readonly Type[] EmptyTypes; //Field offset: 0x0

	private static ReflectionUtils() { }

	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	public static Type EnsureNotByRefType(Type t) { }

	public static Type EnsureNotNullableType(Type t) { }

	private static Nullable<Int32> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	public static T GetAttribute(object attributeProvider, bool inherit) { }

	public static T GetAttribute(object attributeProvider) { }

	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	public static T[] GetAttributes(object attributeProvider, bool inherit) { }

	[Extension]
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	public static Type GetCollectionItemType(Type type) { }

	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	public static object GetDefaultValue(Type type) { }

	[NullableContext(2)]
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	public static object GetMemberValue(MemberInfo member, object target) { }

	[NullableContext(2)]
	public static Type GetObjectType(object v) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType) { }

	public static bool IsByRefLikeType(Type type) { }

	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	public static bool IsIndexedProperty(PropertyInfo property) { }

	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	public static bool IsNullable(Type t) { }

	public static bool IsNullableType(Type t) { }

	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	public static bool IsPublic(PropertyInfo property) { }

	[Extension]
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	[Extension]
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	public static StructMultiKey<String, String> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

}

