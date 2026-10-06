namespace System.Linq.Expressions;

internal sealed class InvocationExpression0 : InvocationExpression
{

	public virtual int ArgumentCount
	{
		 get { } //Length: 3
	}

	public InvocationExpression0(Expression lambda, Type returnType) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

