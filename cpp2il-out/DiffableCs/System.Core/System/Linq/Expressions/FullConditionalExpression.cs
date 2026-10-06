namespace System.Linq.Expressions;

internal class FullConditionalExpression : ConditionalExpression
{
	private readonly Expression _false; //Field offset: 0x20

	internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse) { }

	internal virtual Expression GetFalse() { }

}

