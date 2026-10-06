namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class NoThrowExpressionVisitor : ExpressionVisitor
{
	internal static readonly object ErrorResult; //Field offset: 0x0

	private static NoThrowExpressionVisitor() { }

	public NoThrowExpressionVisitor() { }

	protected virtual Expression VisitConditional(ConditionalExpression node) { }

}

