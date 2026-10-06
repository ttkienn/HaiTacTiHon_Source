namespace System.Linq.Expressions;

internal sealed class Expression3 : Expression<TDelegate>
{
	private object _par0; //Field offset: 0x0
	private readonly ParameterExpression _par1; //Field offset: 0x0
	private readonly ParameterExpression _par2; //Field offset: 0x0

	internal virtual int ParameterCount
	{
		internal get { } //Length: 6
	}

	public Expression3`1(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }

	internal virtual int get_ParameterCount() { }

	internal virtual ParameterExpression GetParameter(int index) { }

	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }

}

