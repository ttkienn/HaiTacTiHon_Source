namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
public class BinaryExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <Right>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Left>k__BackingField; //Field offset: 0x18

	public virtual bool CanReduce
	{
		 get { } //Length: 37
	}

	public LambdaExpression Conversion
	{
		 get { } //Length: 20
	}

	public bool IsLifted
	{
		 get { } //Length: 442
	}

	internal bool IsLiftedLogical
	{
		internal get { } //Length: 386
	}

	public bool IsLiftedToNull
	{
		 get { } //Length: 118
	}

	internal bool IsReferenceComparison
	{
		internal get { } //Length: 236
	}

	public Expression Left
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MethodInfo Method
	{
		 get { } //Length: 20
	}

	public Expression Right
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal BinaryExpression(Expression left, Expression right) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public virtual bool get_CanReduce() { }

	public LambdaExpression get_Conversion() { }

	public bool get_IsLifted() { }

	internal bool get_IsLiftedLogical() { }

	public bool get_IsLiftedToNull() { }

	internal bool get_IsReferenceComparison() { }

	[CompilerGenerated]
	public Expression get_Left() { }

	public MethodInfo get_Method() { }

	[CompilerGenerated]
	public Expression get_Right() { }

	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	internal override LambdaExpression GetConversion() { }

	internal override MethodInfo GetMethod() { }

	private static bool IsOpAssignment(ExpressionType op) { }

	public virtual Expression Reduce() { }

	private Expression ReduceIndex() { }

	private Expression ReduceMember() { }

	internal Expression ReduceUserdefinedLifted() { }

	private Expression ReduceVariable() { }

	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

}

