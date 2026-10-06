namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x20

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

