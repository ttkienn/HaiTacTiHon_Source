namespace System.Linq.Expressions;

internal sealed class InvocationExpression2 : InvocationExpression
{
	private object _arg0; //Field offset: 0x20
	private readonly Expression _arg1; //Field offset: 0x28

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public InvocationExpression2(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

