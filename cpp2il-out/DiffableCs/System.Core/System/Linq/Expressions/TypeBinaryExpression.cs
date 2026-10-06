namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
public sealed class TypeBinaryExpression : Expression
{
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Type <TypeOperand>k__BackingField; //Field offset: 0x20

	public Expression Expression
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	public virtual Type Type
	{
		 get { } //Length: 89
	}

	public Type TypeOperand
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal TypeBinaryExpression(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public Expression get_Expression() { }

	[CompilerGenerated]
	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	[CompilerGenerated]
	public Type get_TypeOperand() { }

	public TypeBinaryExpression Update(Expression expression) { }

}

