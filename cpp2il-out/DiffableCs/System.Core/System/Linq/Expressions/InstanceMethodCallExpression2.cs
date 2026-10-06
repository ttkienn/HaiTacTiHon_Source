namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x20
	private readonly Expression _arg1; //Field offset: 0x28

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

