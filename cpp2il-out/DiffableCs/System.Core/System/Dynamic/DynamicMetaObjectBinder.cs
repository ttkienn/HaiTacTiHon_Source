namespace System.Dynamic;

public abstract class DynamicMetaObjectBinder : CallSiteBinder
{

	internal override bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public override Type ReturnType
	{
		 get { } //Length: 89
	}

	protected DynamicMetaObjectBinder() { }

	public virtual Expression Bind(Object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	private static DynamicMetaObject[] CreateArgumentMetaObjects(Object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	internal override bool get_IsStandardBinder() { }

	public override Type get_ReturnType() { }

	public Expression GetUpdateExpression(Type type) { }

}

