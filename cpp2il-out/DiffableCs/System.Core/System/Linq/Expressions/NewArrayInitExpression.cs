namespace System.Linq.Expressions;

internal sealed class NewArrayInitExpression : NewArrayExpression
{

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	internal NewArrayInitExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	public virtual ExpressionType get_NodeType() { }

}

