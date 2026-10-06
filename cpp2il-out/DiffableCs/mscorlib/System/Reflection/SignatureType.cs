namespace System.Reflection;

internal abstract class SignatureType : Type
{

	public virtual Assembly Assembly
	{
		 get { } //Length: 78
	}

	public virtual string AssemblyQualifiedName
	{
		 get { } //Length: 3
	}

	public virtual Type BaseType
	{
		 get { } //Length: 78
	}

	public abstract bool ContainsGenericParameters
	{
		 get { } //Length: 0
	}

	public virtual IEnumerable<CustomAttributeData> CustomAttributes
	{
		 get { } //Length: 78
	}

	public virtual MethodBase DeclaringMethod
	{
		 get { } //Length: 78
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 78
	}

	internal abstract SignatureType ElementType
	{
		internal get { } //Length: 0
	}

	public virtual string FullName
	{
		 get { } //Length: 3
	}

	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		 get { } //Length: 78
	}

	public abstract int GenericParameterPosition
	{
		 get { } //Length: 0
	}

	public abstract Type[] GenericTypeArguments
	{
		 get { } //Length: 0
	}

	public abstract bool IsConstructedGenericType
	{
		 get { } //Length: 0
	}

	public virtual bool IsEnum
	{
		 get { } //Length: 78
	}

	public abstract bool IsGenericMethodParameter
	{
		 get { } //Length: 0
	}

	public abstract bool IsGenericParameter
	{
		 get { } //Length: 0
	}

	public virtual bool IsGenericType
	{
		 get { } //Length: 68
	}

	public abstract bool IsGenericTypeDefinition
	{
		 get { } //Length: 0
	}

	public virtual bool IsSerializable
	{
		 get { } //Length: 78
	}

	public virtual bool IsSignatureType
	{
		 get { } //Length: 3
	}

	public abstract bool IsSZArray
	{
		 get { } //Length: 0
	}

	public abstract bool IsVariableBoundArray
	{
		 get { } //Length: 0
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	public virtual int MetadataToken
	{
		 get { } //Length: 78
	}

	public virtual Module Module
	{
		 get { } //Length: 78
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract string Namespace
	{
		 get { } //Length: 0
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 78
	}

	public virtual RuntimeTypeHandle TypeHandle
	{
		 get { } //Length: 78
	}

	public virtual Type UnderlyingSystemType
	{
		 get { } //Length: 4
	}

	protected SignatureType() { }

	public virtual Assembly get_Assembly() { }

	public virtual string get_AssemblyQualifiedName() { }

	public virtual Type get_BaseType() { }

	public abstract bool get_ContainsGenericParameters() { }

	public virtual IEnumerable<CustomAttributeData> get_CustomAttributes() { }

	public virtual MethodBase get_DeclaringMethod() { }

	public virtual Type get_DeclaringType() { }

	internal abstract SignatureType get_ElementType() { }

	public virtual string get_FullName() { }

	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	public abstract int get_GenericParameterPosition() { }

	public abstract Type[] get_GenericTypeArguments() { }

	public abstract bool get_IsConstructedGenericType() { }

	public virtual bool get_IsEnum() { }

	public abstract bool get_IsGenericMethodParameter() { }

	public abstract bool get_IsGenericParameter() { }

	public virtual bool get_IsGenericType() { }

	public abstract bool get_IsGenericTypeDefinition() { }

	public virtual bool get_IsSerializable() { }

	public virtual bool get_IsSignatureType() { }

	public abstract bool get_IsSZArray() { }

	public abstract bool get_IsVariableBoundArray() { }

	public virtual MemberTypes get_MemberType() { }

	public virtual int get_MetadataToken() { }

	public virtual Module get_Module() { }

	public abstract string get_Name() { }

	public abstract string get_Namespace() { }

	public virtual Type get_ReflectedType() { }

	public virtual RuntimeTypeHandle get_TypeHandle() { }

	public virtual Type get_UnderlyingSystemType() { }

	public abstract int GetArrayRank() { }

	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	public virtual Type GetElementType() { }

	public virtual string GetEnumName(object value) { }

	public virtual String[] GetEnumNames() { }

	public virtual Type GetEnumUnderlyingType() { }

	public virtual Array GetEnumValues() { }

	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	public abstract Type[] GetGenericArguments() { }

	public virtual Type[] GetGenericParameterConstraints() { }

	public abstract Type GetGenericTypeDefinition() { }

	public virtual Type[] GetInterfaces() { }

	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	protected virtual TypeCode GetTypeCodeImpl() { }

	protected abstract bool HasElementTypeImpl() { }

	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	protected abstract bool IsArrayImpl() { }

	public virtual bool IsAssignableFrom(Type c) { }

	protected abstract bool IsByRefImpl() { }

	protected virtual bool IsCOMObjectImpl() { }

	protected virtual bool IsContextfulImpl() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual bool IsEnumDefined(object value) { }

	public virtual bool IsEquivalentTo(Type other) { }

	public virtual bool IsInstanceOfType(object o) { }

	protected virtual bool IsMarshalByRefImpl() { }

	protected abstract bool IsPointerImpl() { }

	protected virtual bool IsPrimitiveImpl() { }

	public virtual bool IsSubclassOf(Type c) { }

	protected virtual bool IsValueTypeImpl() { }

	public virtual Type MakeArrayType() { }

	public virtual Type MakeArrayType(int rank) { }

	public virtual Type MakeByRefType() { }

	public virtual Type MakeGenericType(Type[] typeArguments) { }

	public virtual Type MakePointerType() { }

	public abstract string ToString() { }

}

