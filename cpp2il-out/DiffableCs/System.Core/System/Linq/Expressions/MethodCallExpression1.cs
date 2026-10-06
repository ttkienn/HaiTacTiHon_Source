namespace System.Linq.Expressions;

internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x18

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public MethodCallExpression1(MethodInfo method, Expression arg0) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

