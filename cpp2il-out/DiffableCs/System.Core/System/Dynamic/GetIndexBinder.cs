namespace System.Dynamic;

public abstract class GetIndexBinder : DynamicMetaObjectBinder
{

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion) { }

}

