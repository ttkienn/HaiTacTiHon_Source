namespace System.Linq.Expressions;

internal sealed class LogicalBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20

	public virtual ExpressionType NodeType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Type Type
	{
		 get { } //Length: 89
	}

	internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right) { }

	[CompilerGenerated]
	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

}

