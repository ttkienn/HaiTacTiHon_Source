namespace System.Linq.Expressions;

internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider
{
	private object _arg0; //Field offset: 0x18
	private readonly Expression _arg1; //Field offset: 0x20
	private readonly Expression _arg2; //Field offset: 0x28

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public MethodCallExpression3(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

