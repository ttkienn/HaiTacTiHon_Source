namespace System.Linq.Expressions;

internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
{
	private readonly LambdaExpression _conversion; //Field offset: 0x38

	internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	internal virtual LambdaExpression GetConversion() { }

}

