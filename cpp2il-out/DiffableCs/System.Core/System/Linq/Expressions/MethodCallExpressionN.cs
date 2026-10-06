namespace System.Linq.Expressions;

internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x18

	public virtual int ArgumentCount
	{
		 get { } //Length: 70
	}

	public MethodCallExpressionN(MethodInfo method, IReadOnlyList<Expression> args) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

