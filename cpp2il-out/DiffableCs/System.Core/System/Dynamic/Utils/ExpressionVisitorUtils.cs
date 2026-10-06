namespace System.Dynamic.Utils;

internal static class ExpressionVisitorUtils
{

	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }

	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

}

