namespace System.Linq.Expressions;

internal sealed class Block5 : BlockExpression
{
	private object _arg0; //Field offset: 0x10
	private readonly Expression _arg1; //Field offset: 0x18
	private readonly Expression _arg2; //Field offset: 0x20
	private readonly Expression _arg3; //Field offset: 0x28
	private readonly Expression _arg4; //Field offset: 0x30

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 6
	}

	internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

