namespace System.Dynamic;

public abstract class SetMemberBinder : DynamicMetaObjectBinder
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

	internal virtual bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 89
	}

	protected SetMemberBinder(string name, bool ignoreCase) { }

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public bool get_IgnoreCase() { }

	internal virtual bool get_IsStandardBinder() { }

	[CompilerGenerated]
	public string get_Name() { }

	public virtual Type get_ReturnType() { }

}

