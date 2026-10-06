namespace System.Linq.Expressions;

internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider
{

	public virtual int ArgumentCount
	{
		 get { } //Length: 3
	}

	public MethodCallExpression0(MethodInfo method) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

