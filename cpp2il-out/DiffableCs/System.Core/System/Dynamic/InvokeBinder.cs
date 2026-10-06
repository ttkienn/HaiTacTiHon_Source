namespace System.Dynamic;

public abstract class InvokeBinder : DynamicMetaObjectBinder
{

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion) { }

	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

}

