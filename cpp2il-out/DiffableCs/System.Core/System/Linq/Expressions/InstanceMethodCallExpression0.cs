namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider
{

	public virtual int ArgumentCount
	{
		 get { } //Length: 3
	}

	public InstanceMethodCallExpression0(MethodInfo method, Expression instance) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

