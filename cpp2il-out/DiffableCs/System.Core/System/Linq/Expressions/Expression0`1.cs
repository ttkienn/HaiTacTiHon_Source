namespace System.Linq.Expressions;

internal sealed class Expression0 : Expression<TDelegate>
{

	internal virtual int ParameterCount
	{
		internal get { } //Length: 3
	}

	public Expression0`1(Expression body) { }

	internal virtual int get_ParameterCount() { }

	internal virtual ParameterExpression GetParameter(int index) { }

	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

