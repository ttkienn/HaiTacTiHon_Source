namespace System.Reflection;

public struct CustomAttributeTypedArgument
{
	[CompilerGenerated]
	private readonly Type <ArgumentType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; //Field offset: 0x8

	public Type ArgumentType
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public object Value
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public CustomAttributeTypedArgument(object value) { }

	public CustomAttributeTypedArgument(Type argumentType, object value) { }

	private static object CanonicalizeValue(object value) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Type get_ArgumentType() { }

	[CompilerGenerated]
	[IsReadOnly]
	public object get_Value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	public virtual string ToString() { }

	internal string ToString(bool typed) { }

}

