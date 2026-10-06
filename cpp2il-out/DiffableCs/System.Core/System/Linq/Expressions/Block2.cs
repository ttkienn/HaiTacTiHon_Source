namespace System.Linq.Expressions;

internal sealed class Block2 : BlockExpression
{
	private object _arg0; //Field offset: 0x10
	private readonly Expression _arg1; //Field offset: 0x18

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 6
	}

	internal Block2(Expression arg0, Expression arg1) { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

