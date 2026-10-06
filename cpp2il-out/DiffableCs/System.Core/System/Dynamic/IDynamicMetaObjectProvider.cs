namespace System.Dynamic;

public interface IDynamicMetaObjectProvider
{

	public DynamicMetaObject GetMetaObject(Expression parameter) { }

}

