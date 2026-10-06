namespace System.Dynamic;

public abstract class BinaryOperationBinder : DynamicMetaObjectBinder
{
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; //Field offset: 0x18

	public ExpressionType Operation
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion) { }

	[CompilerGenerated]
	public ExpressionType get_Operation() { }

}

