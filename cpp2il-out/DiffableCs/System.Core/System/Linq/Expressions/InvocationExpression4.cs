namespace System.Linq.Expressions;

internal sealed class InvocationExpression4 : InvocationExpression
{
	private object _arg0; //Field offset: 0x20
	private readonly Expression _arg1; //Field offset: 0x28
	private readonly Expression _arg2; //Field offset: 0x30
	private readonly Expression _arg3; //Field offset: 0x38

	public virtual int ArgumentCount
	{
		 get { } //Length: 6
	}

	public InvocationExpression4(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	public virtual int get_ArgumentCount() { }

	public virtual Expression GetArgument(int index) { }

	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

