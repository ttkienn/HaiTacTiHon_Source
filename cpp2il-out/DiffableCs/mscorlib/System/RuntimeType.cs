namespace System;

internal class RuntimeType : TypeInfo, ISerializable, ICloneable
{
	[DefaultMember("Item")]
	private struct ListBuilder
	{
		private T[] _items; //Field offset: 0x0
		private T _item; //Field offset: 0x0
		private int _count; //Field offset: 0x0
		private int _capacity; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 191
		}

		public T Item
		{
			 get { } //Length: 46
		}

		public ListBuilder`1(int capacity) { }

		public void Add(T item) { }

		public void CopyTo(Object[] array, int index) { }

		public int get_Count() { }

		public T get_Item(int index) { }

		public T[] ToArray() { }

	}

	public enum MemberListType
	{
		All = 0,
		CaseSensitive = 1,
		CaseInsensitive = 2,
		HandleToInfo = 3,
	}

	internal static readonly RuntimeType ValueType; //Field offset: 0x0
	private const BindingFlags ClassicBindingMask = 61696; //Field offset: 0x0
	private const BindingFlags BinderNonFieldGetSet = 16773888; //Field offset: 0x0
	private const BindingFlags BinderSetInvokeField = 2304; //Field offset: 0x0
	private const BindingFlags BinderGetSetField = 3072; //Field offset: 0x0
	private const BindingFlags BinderSetInvokeProperty = 8448; //Field offset: 0x0
	private const BindingFlags BinderNonCreateInstance = 15616; //Field offset: 0x0
	private const BindingFlags InvocationMask = 65280; //Field offset: 0x0
	private const BindingFlags BinderGetSetProperty = 12288; //Field offset: 0x0
	private const BindingFlags MemberBindingMask = 255; //Field offset: 0x0
	private const int GenericParameterCountAny = -1; //Field offset: 0x0
	internal static readonly RuntimeType EnumType; //Field offset: 0x8
	private static readonly RuntimeType ObjectType; //Field offset: 0x10
	private static readonly RuntimeType StringType; //Field offset: 0x18
	private static readonly RuntimeType DelegateType; //Field offset: 0x20
	private static Type[] s_SICtorParamTypes; //Field offset: 0x28
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; //Field offset: 0x30
	private static RuntimeType s_typedRef; //Field offset: 0x38
	private MonoTypeInfo type_info; //Field offset: 0x18
	internal object GenericCache; //Field offset: 0x20
	private RuntimeConstructorInfo m_serializationCtor; //Field offset: 0x28

	public virtual Assembly Assembly
	{
		 get { } //Length: 7
	}

	public virtual string AssemblyQualifiedName
	{
		 get { } //Length: 12
	}

	public virtual Type BaseType
	{
		 get { } //Length: 7
	}

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 296
	}

	public virtual MethodBase DeclaringMethod
	{
		 get { } //Length: 5
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 5
	}

	public virtual string FullName
	{
		 get { } //Length: 263
	}

	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		 get { } //Length: 190
	}

	public virtual int GenericParameterPosition
	{
		 get { } //Length: 140
	}

	public virtual bool IsConstructedGenericType
	{
		 get { } //Length: 71
	}

	public virtual bool IsEnum
	{
		 get { } //Length: 98
	}

	public virtual bool IsGenericParameter
	{
		 get { } //Length: 7
	}

	public virtual bool IsGenericType
	{
		 get { } //Length: 7
	}

	public virtual bool IsGenericTypeDefinition
	{
		 get { } //Length: 7
	}

	internal virtual bool IsSzArray
	{
		internal get { } //Length: 7
	}

	public virtual bool IsSZArray
	{
		 get { } //Length: 93
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 64
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 7
	}

	public virtual Module Module
	{
		 get { } //Length: 7
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual string Namespace
	{
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 20
	}

	public virtual RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 39
	}

	public virtual Type UnderlyingSystemType
	{
		 get { } //Length: 4
	}

	private static RuntimeType() { }

	internal RuntimeType() { }

	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	public override object Clone() { }

	private void CreateInstanceCheckThis() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes, ref StackCrawlMark stackMark) { }

	private static object CreateInstanceInternal(Type type) { }

	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	public virtual bool Equals(object obj) { }

	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) { }

	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) { }

	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	internal virtual string FormatTypeName(bool serialization) { }

	public virtual Assembly get_Assembly() { }

	public virtual string get_AssemblyQualifiedName() { }

	public virtual Type get_BaseType() { }

	public virtual bool get_ContainsGenericParameters() { }

	public virtual MethodBase get_DeclaringMethod() { }

	public virtual Type get_DeclaringType() { }

	public virtual string get_FullName() { }

	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	public virtual int get_GenericParameterPosition() { }

	public virtual bool get_IsConstructedGenericType() { }

	public virtual bool get_IsEnum() { }

	public virtual bool get_IsGenericParameter() { }

	public virtual bool get_IsGenericType() { }

	public virtual bool get_IsGenericTypeDefinition() { }

	internal virtual bool get_IsSzArray() { }

	public virtual bool get_IsSZArray() { }

	public virtual MemberTypes get_MemberType() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual string get_Namespace() { }

	public virtual Type get_ReflectedType() { }

	public virtual RuntimeTypeHandle get_TypeHandle() { }

	public virtual Type get_UnderlyingSystemType() { }

	public virtual int GetArrayRank() { }

	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	private RuntimeType GetBaseType() { }

	private string GetCachedName(TypeNameKind kind) { }

	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	private string GetDefaultMemberName() { }

	public virtual Type GetElementType() { }

	public virtual string GetEnumName(object value) { }

	public virtual String[] GetEnumNames() { }

	public virtual Type GetEnumUnderlyingType() { }

	public virtual Array GetEnumValues() { }

	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	private IntPtr GetEvents_native(IntPtr name, MemberListType listType) { }

	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	internal string getFullName(bool full_name, bool assembly_qualified) { }

	public virtual Type[] GetGenericArguments() { }

	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	internal RuntimeType[] GetGenericArgumentsInternal() { }

	private GenericParameterAttributes GetGenericParameterAttributes() { }

	public virtual Type[] GetGenericParameterConstraints() { }

	private int GetGenericParameterPosition() { }

	public virtual Type GetGenericTypeDefinition() { }

	public virtual int GetHashCode() { }

	public virtual Type[] GetInterfaces() { }

	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	private ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, MemberListType listType) { }

	public virtual Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, MemberListType listType) { }

	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	internal RuntimeAssembly GetRuntimeAssembly() { }

	internal RuntimeModule GetRuntimeModule() { }

	internal RuntimeConstructorInfo GetSerializationCtor() { }

	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	protected virtual TypeCode GetTypeCodeImpl() { }

	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	protected virtual bool HasElementTypeImpl() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, Object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParams) { }

	protected virtual bool IsArrayImpl() { }

	public virtual bool IsAssignableFrom(Type c) { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsCOMObjectImpl() { }

	protected virtual bool IsContextfulImpl() { }

	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual bool IsEnumDefined(object value) { }

	public virtual bool IsEquivalentTo(Type other) { }

	private bool IsGenericCOMObjectImpl() { }

	public virtual bool IsInstanceOfType(object o) { }

	protected virtual bool IsPointerImpl() { }

	protected virtual bool IsPrimitiveImpl() { }

	[ComVisible(True)]
	public virtual bool IsSubclassOf(Type type) { }

	protected virtual bool IsValueTypeImpl() { }

	private Type make_array_type(int rank) { }

	private Type make_byref_type() { }

	public virtual Type MakeArrayType() { }

	public virtual Type MakeArrayType(int rank) { }

	public virtual Type MakeByRefType() { }

	public virtual Type MakeGenericType(Type[] instantiation) { }

	private static Type MakeGenericType(Type gt, Type[] types) { }

	private static Type MakePointerType(Type type) { }

	public virtual Type MakePointerType() { }

	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	private static void SplitName(string fullname, out string name, out string ns) { }

	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	public virtual string ToString() { }

	private object TryConvertToType(object value, ref bool failed) { }

}

