namespace System.Reflection;

public abstract class ConstructorInfo : MethodBase
{
	public static readonly string ConstructorName; //Field offset: 0x0
	public static readonly string TypeConstructorName; //Field offset: 0x8

	public virtual MemberTypes MemberType
	{
		 get { } //Length: 6
	}

	private static ConstructorInfo() { }

	protected ConstructorInfo() { }

	public virtual bool Equals(object obj) { }

	public virtual MemberTypes get_MemberType() { }

	public virtual int GetHashCode() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	public object Invoke(Object[] parameters) { }

	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture) { }

	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

}

