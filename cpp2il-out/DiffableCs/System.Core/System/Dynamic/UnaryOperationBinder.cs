namespace System.Dynamic;

public abstract class UnaryOperationBinder : DynamicMetaObjectBinder
{

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }

	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

}

