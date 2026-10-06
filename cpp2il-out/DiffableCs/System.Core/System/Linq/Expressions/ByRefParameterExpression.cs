namespace System.Linq.Expressions;

internal sealed class ByRefParameterExpression : TypedParameterExpression
{

	internal ByRefParameterExpression(Type type, string name) { }

	internal virtual bool GetIsByRef() { }

}

