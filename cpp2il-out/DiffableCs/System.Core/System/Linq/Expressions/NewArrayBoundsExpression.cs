namespace System.Linq.Expressions;

internal sealed class NewArrayBoundsExpression : NewArrayExpression
{

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	internal NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions) { }

	public virtual ExpressionType get_NodeType() { }

}

