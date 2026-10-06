namespace System.Linq.Expressions;

internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x18
	private readonly Expression _arg1; //Field offset: 0x20

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

