namespace System.Linq.Expressions;

internal class SimpleBinaryExpression : BinaryExpression
{
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x28

	public virtual ExpressionType NodeType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[CompilerGenerated]
	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

}

