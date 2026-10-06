namespace System.Linq.Expressions;

internal sealed class Scope1 : ScopeExpression
{
	private object _body; //Field offset: 0x18

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 6
	}

	internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	private Scope1(IReadOnlyList<ParameterExpression> variables, object body) { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

