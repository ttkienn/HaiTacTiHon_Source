namespace System;

public abstract class Type : MemberInfo
{
	private static Binder s_defaultBinder; //Field offset: 0x0
	private const BindingFlags DefaultLookup = 28; //Field offset: 0x0
	internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType"; //Field offset: 0x0
	public static readonly char Delimiter; //Field offset: 0x8
	public static readonly Type[] EmptyTypes; //Field offset: 0x10
	public static readonly object Missing; //Field offset: 0x18
	public static readonly MemberFilter FilterAttribute; //Field offset: 0x20
	public static readonly MemberFilter FilterName; //Field offset: 0x28
	public static readonly MemberFilter FilterNameIgnoreCase; //Field offset: 0x30
	internal RuntimeTypeHandle _impl; //Field offset: 0x10

	public abstract Assembly Assembly
	{
		 get { } //Length: 0
	}

	public abstract string AssemblyQualifiedName
	{
		 get { } //Length: 0
	}

	public override TypeAttributes Attributes
	{
		 get { } //Length: 20
	}

	public abstract Type BaseType
	{
		 get { } //Length: 0
	}

	public override bool ContainsGenericParameters
	{
		 get { } //Length: 336
	}

	public override MethodBase DeclaringMethod
	{
		 get { } //Length: 3
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 3
	}

	public static Binder DefaultBinder
	{
		 get { } //Length: 223
	}

	public abstract string FullName
	{
		 get { } //Length: 0
	}

	internal string FullNameOrDefault
	{
		internal get { } //Length: 139
	}

	public override GenericParameterAttributes GenericParameterAttributes
	{
		 get { } //Length: 62
	}

	public override int GenericParameterPosition
	{
		 get { } //Length: 78
	}

	public override Type[] GenericTypeArguments
	{
		 get { } //Length: 134
	}

	public override bool HasElementType
	{
		 get { } //Length: 20
	}

	internal string InternalNameIfAvailable
	{
		internal get { } //Length: 42
	}

	public override bool IsAbstract
	{
		 get { } //Length: 36
	}

	public override bool IsArray
	{
		 get { } //Length: 20
	}

	public override bool IsByRef
	{
		 get { } //Length: 20
	}

	public override bool IsClass
	{
		 get { } //Length: 73
	}

	public override bool IsCollectible
	{
		 get { } //Length: 3
	}

	public override bool IsCOMObject
	{
		 get { } //Length: 20
	}

	public override bool IsConstructedGenericType
	{
		 get { } //Length: 39
	}

	public override bool IsContextful
	{
		 get { } //Length: 20
	}

	public override bool IsEnum
	{
		 get { } //Length: 195
	}

	public override bool IsExplicitLayout
	{
		 get { } //Length: 35
	}

	public override bool IsGenericMethodParameter
	{
		 get { } //Length: 78
	}

	public override bool IsGenericParameter
	{
		 get { } //Length: 3
	}

	public override bool IsGenericType
	{
		 get { } //Length: 3
	}

	public override bool IsGenericTypeDefinition
	{
		 get { } //Length: 3
	}

	public override bool IsInterface
	{
		 get { } //Length: 199
	}

	public override bool IsMarshalByRef
	{
		 get { } //Length: 20
	}

	public bool IsNested
	{
		 get { } //Length: 95
	}

	public override bool IsNestedAssembly
	{
		 get { } //Length: 36
	}

	public override bool IsNestedPublic
	{
		 get { } //Length: 35
	}

	public override bool IsNotPublic
	{
		 get { } //Length: 33
	}

	public override bool IsPointer
	{
		 get { } //Length: 20
	}

	public override bool IsPrimitive
	{
		 get { } //Length: 20
	}

	public override bool IsPublic
	{
		 get { } //Length: 35
	}

	public override bool IsSealed
	{
		 get { } //Length: 36
	}

	public override bool IsSerializable
	{
		 get { } //Length: 477
	}

	public override bool IsSignatureType
	{
		 get { } //Length: 3
	}

	internal override bool IsSzArray
	{
		internal get { } //Length: 3
	}

	public override bool IsSZArray
	{
		 get { } //Length: 39
	}

	public override bool IsValueType
	{
		 get { } //Length: 20
	}

	public override bool IsVariableBoundArray
	{
		 get { } //Length: 71
	}

	public bool IsVisible
	{
		 get { } //Length: 491
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	public abstract Module Module
	{
		 get { } //Length: 0
	}

	internal string NameOrDefault
	{
		internal get { } //Length: 96
	}

	public abstract string Namespace
	{
		 get { } //Length: 0
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 3
	}

	public override RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 62
	}

	public abstract Type UnderlyingSystemType
	{
		 get { } //Length: 0
	}

	private static Type() { }

	protected Type() { }

	private static int BinarySearch(Array array, object value) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(Type o) { }

	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) { }

	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) { }

	private static bool FilterNameImpl(MemberInfo m, object filterCriteria) { }

	internal string FormatTypeName() { }

	internal override string FormatTypeName(bool serialization) { }

	public abstract Assembly get_Assembly() { }

	public abstract string get_AssemblyQualifiedName() { }

	public override TypeAttributes get_Attributes() { }

	public abstract Type get_BaseType() { }

	public override bool get_ContainsGenericParameters() { }

	public override MethodBase get_DeclaringMethod() { }

	public virtual Type get_DeclaringType() { }

	public static Binder get_DefaultBinder() { }

	public abstract string get_FullName() { }

	internal string get_FullNameOrDefault() { }

	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	public override int get_GenericParameterPosition() { }

	public override Type[] get_GenericTypeArguments() { }

	public override bool get_HasElementType() { }

	internal string get_InternalNameIfAvailable() { }

	public override bool get_IsAbstract() { }

	public override bool get_IsArray() { }

	public override bool get_IsByRef() { }

	public override bool get_IsClass() { }

	public override bool get_IsCollectible() { }

	public override bool get_IsCOMObject() { }

	public override bool get_IsConstructedGenericType() { }

	public override bool get_IsContextful() { }

	public override bool get_IsEnum() { }

	public override bool get_IsExplicitLayout() { }

	public override bool get_IsGenericMethodParameter() { }

	public override bool get_IsGenericParameter() { }

	public override bool get_IsGenericType() { }

	public override bool get_IsGenericTypeDefinition() { }

	public override bool get_IsInterface() { }

	public override bool get_IsMarshalByRef() { }

	public bool get_IsNested() { }

	public override bool get_IsNestedAssembly() { }

	public override bool get_IsNestedPublic() { }

	public override bool get_IsNotPublic() { }

	public override bool get_IsPointer() { }

	public override bool get_IsPrimitive() { }

	public override bool get_IsPublic() { }

	public override bool get_IsSealed() { }

	public override bool get_IsSerializable() { }

	public override bool get_IsSignatureType() { }

	internal override bool get_IsSzArray() { }

	public override bool get_IsSZArray() { }

	public override bool get_IsValueType() { }

	public override bool get_IsVariableBoundArray() { }

	public bool get_IsVisible() { }

	public virtual MemberTypes get_MemberType() { }

	public abstract Module get_Module() { }

	internal string get_NameOrDefault() { }

	public abstract string get_Namespace() { }

	public virtual Type get_ReflectedType() { }

	public override RuntimeTypeHandle get_TypeHandle() { }

	public abstract Type get_UnderlyingSystemType() { }

	public override int GetArrayRank() { }

	protected abstract TypeAttributes GetAttributeFlagsImpl() { }

	[ComVisible(True)]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	public override ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	public override ConstructorInfo GetConstructor(Type[] types) { }

	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	public override ConstructorInfo[] GetConstructors() { }

	[ComVisible(True)]
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public abstract Type GetElementType() { }

	private void GetEnumData(out String[] enumNames, out Array enumValues) { }

	public override string GetEnumName(object value) { }

	public override String[] GetEnumNames() { }

	private Array GetEnumRawConstantValues() { }

	public override Type GetEnumUnderlyingType() { }

	public override Array GetEnumValues() { }

	public override EventInfo GetEvent(string name) { }

	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	public override FieldInfo GetField(string name) { }

	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	public override Type[] GetGenericArguments() { }

	public override Type[] GetGenericParameterConstraints() { }

	public override Type GetGenericTypeDefinition() { }

	public virtual int GetHashCode() { }

	public abstract Type[] GetInterfaces() { }

	public override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	public override MemberInfo[] GetMember(string name) { }

	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	public override MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) { }

	public override MethodInfo GetMethod(string name, Type[] types) { }

	public override MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	public override MethodInfo GetMethod(string name) { }

	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public override MethodInfo[] GetMethods() { }

	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public abstract Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	public override PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	public override PropertyInfo GetProperty(string name, Type returnType) { }

	public override PropertyInfo GetProperty(string name) { }

	public override PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	internal Type GetRootElementType() { }

	public override Type GetType() { }

	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	public static Type GetType(string typeName, bool throwOnError) { }

	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError) { }

	public static Type GetType(string typeName) { }

	public static TypeCode GetTypeCode(Type type) { }

	protected override TypeCode GetTypeCodeImpl() { }

	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	protected abstract bool HasElementTypeImpl() { }

	internal bool ImplementInterface(Type ifaceType) { }

	private static Type internal_from_handle(IntPtr handle) { }

	internal override string InternalGetNameIfAvailable(ref Type rootCauseForFailure) { }

	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	protected abstract bool IsArrayImpl() { }

	public override bool IsAssignableFrom(Type c) { }

	protected abstract bool IsByRefImpl() { }

	protected abstract bool IsCOMObjectImpl() { }

	protected override bool IsContextfulImpl() { }

	public override bool IsEnumDefined(object value) { }

	public override bool IsEquivalentTo(Type other) { }

	public override bool IsInstanceOfType(object o) { }

	internal static bool IsIntegerType(Type t) { }

	protected override bool IsMarshalByRefImpl() { }

	protected abstract bool IsPointerImpl() { }

	protected abstract bool IsPrimitiveImpl() { }

	internal bool IsRuntimeImplemented() { }

	[ComVisible(True)]
	public override bool IsSubclassOf(Type c) { }

	protected override bool IsValueTypeImpl() { }

	public override Type MakeArrayType() { }

	public override Type MakeArrayType(int rank) { }

	public override Type MakeByRefType() { }

	public static Type MakeGenericSignatureType(Type genericTypeDefinition, Type[] typeArguments) { }

	public override Type MakeGenericType(Type[] typeArguments) { }

	public override Type MakePointerType() { }

	public static bool op_Equality(Type left, Type right) { }

	public static bool op_Inequality(Type left, Type right) { }

	public virtual string ToString() { }

}

