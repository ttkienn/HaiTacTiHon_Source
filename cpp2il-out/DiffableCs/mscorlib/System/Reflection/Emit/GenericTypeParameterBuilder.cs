namespace System.Reflection.Emit;

public sealed class GenericTypeParameterBuilder : TypeInfo
{

	public virtual Assembly Assembly
	{
		 get { } //Length: 62
	}

	public virtual string AssemblyQualifiedName
	{
		 get { } //Length: 62
	}

	public virtual Type BaseType
	{
		 get { } //Length: 62
	}

	public virtual string FullName
	{
		 get { } //Length: 62
	}

	public virtual Module Module
	{
		 get { } //Length: 62
	}

	public virtual string Name
	{
		 get { } //Length: 62
	}

	public virtual string Namespace
	{
		 get { } //Length: 62
	}

	public virtual Type UnderlyingSystemType
	{
		 get { } //Length: 62
	}

	public virtual Assembly get_Assembly() { }

	public virtual string get_AssemblyQualifiedName() { }

	public virtual Type get_BaseType() { }

	public virtual string get_FullName() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual string get_Namespace() { }

	public virtual Type get_UnderlyingSystemType() { }

	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Type GetElementType() { }

	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	public virtual Type[] GetInterfaces() { }

	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) { }

	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	protected virtual bool HasElementTypeImpl() { }

	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParameters) { }

	protected virtual bool IsArrayImpl() { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsCOMObjectImpl() { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	protected virtual bool IsPointerImpl() { }

	protected virtual bool IsPrimitiveImpl() { }

}

