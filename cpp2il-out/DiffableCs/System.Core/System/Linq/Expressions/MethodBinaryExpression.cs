namespace System.Linq.Expressions;

internal class MethodBinaryExpression : SimpleBinaryExpression
{
	private readonly MethodInfo _method; //Field offset: 0x30

	internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) { }

	internal virtual MethodInfo GetMethod() { }

}

