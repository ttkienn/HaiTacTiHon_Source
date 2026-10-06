namespace System.Dynamic;

public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; //Field offset: 0x20

	public bool IgnoreCase
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public bool get_IgnoreCase() { }

	[CompilerGenerated]
	public string get_Name() { }

}

