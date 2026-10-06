namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
public sealed class UnaryExpression : Expression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Expression <Operand>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x28

	public virtual bool CanReduce
	{
		 get { } //Length: 37
	}

	public bool IsLifted
	{
		 get { } //Length: 618
	}

	public bool IsLiftedToNull
	{
		 get { } //Length: 118
	}

	private bool IsPrefix
	{
		private get { } //Length: 75
	}

	public MethodInfo Method
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Expression Operand
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	private UnaryExpression FunctionalOp(Expression operand) { }

	public virtual bool get_CanReduce() { }

	public bool get_IsLifted() { }

	public bool get_IsLiftedToNull() { }

	private bool get_IsPrefix() { }

	[CompilerGenerated]
	public MethodInfo get_Method() { }

	[CompilerGenerated]
	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public Expression get_Operand() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	public virtual Expression Reduce() { }

	private Expression ReduceIndex() { }

	private Expression ReduceMember() { }

	private Expression ReduceVariable() { }

	public UnaryExpression Update(Expression operand) { }

}

