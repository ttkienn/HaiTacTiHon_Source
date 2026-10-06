namespace System.Dynamic;

public abstract class ConvertBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x18

	public Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public Type get_Type() { }

}

