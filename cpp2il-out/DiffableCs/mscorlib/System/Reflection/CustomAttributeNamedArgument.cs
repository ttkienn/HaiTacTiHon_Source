namespace System.Reflection;

public struct CustomAttributeNamedArgument
{
	[CompilerGenerated]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <IsField>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; //Field offset: 0x18
	private readonly Type _attributeType; //Field offset: 0x20
	private MemberInfo _lazyMemberInfo; //Field offset: 0x28

	public bool IsField
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public MemberInfo MemberInfo
	{
		 get { } //Length: 320
	}

	public string MemberName
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
	}

	public CustomAttributeTypedArgument TypedValue
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 10
	}

	internal CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	public CustomAttributeNamedArgument(MemberInfo memberInfo, object value) { }

	public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsField() { }

	public MemberInfo get_MemberInfo() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_MemberName() { }

	[CompilerGenerated]
	[IsReadOnly]
	public CustomAttributeTypedArgument get_TypedValue() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	public virtual string ToString() { }

}

