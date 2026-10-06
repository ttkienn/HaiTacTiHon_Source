namespace System.Reflection;

public abstract class MethodInfo : MethodBase
{

	internal override int GenericParameterCount
	{
		internal get { } //Length: 41
	}

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	public override ParameterInfo ReturnParameter
	{
		 get { } //Length: 39
	}

	public override Type ReturnType
	{
		 get { } //Length: 39
	}

	protected MethodInfo() { }

	public override Delegate CreateDelegate(Type delegateType) { }

	public override Delegate CreateDelegate(Type delegateType, object target) { }

	public virtual bool Equals(object obj) { }

	internal override int get_GenericParameterCount() { }

	public virtual MemberTypes get_MemberType() { }

	public override ParameterInfo get_ReturnParameter() { }

	public override Type get_ReturnType() { }

	public abstract MethodInfo GetBaseDefinition() { }

	public virtual Type[] GetGenericArguments() { }

	public override MethodInfo GetGenericMethodDefinition() { }

	public virtual int GetHashCode() { }

	public override MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

}

