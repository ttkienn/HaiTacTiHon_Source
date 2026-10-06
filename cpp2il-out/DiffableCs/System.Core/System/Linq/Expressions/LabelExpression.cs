namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
public sealed class LabelExpression : Expression
{
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <DefaultValue>k__BackingField; //Field offset: 0x18

	public Expression DefaultValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public LabelTarget Target
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		 get { } //Length: 27
	}

	internal LabelExpression(LabelTarget label, Expression defaultValue) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	[CompilerGenerated]
	public Expression get_DefaultValue() { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public LabelTarget get_Target() { }

	public virtual Type get_Type() { }

	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }

}

