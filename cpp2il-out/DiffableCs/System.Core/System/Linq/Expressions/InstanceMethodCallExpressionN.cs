namespace System.Linq.Expressions;

internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x20

	public virtual int ArgumentCount
	{
		 get { } //Length: 70
	}

	public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

