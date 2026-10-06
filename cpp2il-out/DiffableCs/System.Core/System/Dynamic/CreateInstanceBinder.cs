namespace System.Dynamic;

public abstract class CreateInstanceBinder : DynamicMetaObjectBinder
{

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

}

