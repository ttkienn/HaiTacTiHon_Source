namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
public sealed class LoopExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly LabelTarget <BreakLabel>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly LabelTarget <ContinueLabel>k__BackingField; //Field offset: 0x20

	public Expression Body
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LabelTarget BreakLabel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LabelTarget ContinueLabel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		 get { } //Length: 123
	}

	internal LoopExpression(Expression body, LabelTarget break, LabelTarget continue) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public Expression get_Body() { }

	[CompilerGenerated]
	public LabelTarget get_BreakLabel() { }

	[CompilerGenerated]
	public LabelTarget get_ContinueLabel() { }

	public virtual ExpressionType get_NodeType() { }

	public virtual Type get_Type() { }

	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }

}

