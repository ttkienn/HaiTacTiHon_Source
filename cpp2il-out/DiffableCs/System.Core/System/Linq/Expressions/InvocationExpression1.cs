namespace System.Linq.Expressions;

internal sealed class InvocationExpression1 : InvocationExpression
{
	private object _arg0; //Field offset: 0x20

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public InvocationExpression1(Expression lambda, Type returnType, Expression arg0) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

