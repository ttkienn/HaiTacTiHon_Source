namespace System.Linq.Expressions;

internal class BlockN : BlockExpression
{
	private IReadOnlyList<Expression> _expressions; //Field offset: 0x10

	internal virtual int ExpressionCount
	{
		internal get { } //Length: 70
	}

	internal BlockN(IReadOnlyList<Expression> expressions) { }

	internal virtual int get_ExpressionCount() { }

	internal virtual Expression GetExpression(int index) { }

	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

