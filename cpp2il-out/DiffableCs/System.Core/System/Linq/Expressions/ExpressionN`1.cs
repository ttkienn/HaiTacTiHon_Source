namespace System.Linq.Expressions;

internal class ExpressionN : Expression<TDelegate>
{
	private IReadOnlyList<ParameterExpression> _parameters; //Field offset: 0x0

	internal virtual int ParameterCount
	{
		internal get { } //Length: 70
	}

	public ExpressionN`1(Expression body, IReadOnlyList<ParameterExpression> parameters) { }

	internal virtual int get_ParameterCount() { }

	internal virtual ParameterExpression GetParameter(int index) { }

	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

