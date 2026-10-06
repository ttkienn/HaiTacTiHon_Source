namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
public class InvocationExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; //Field offset: 0x18

	[ExcludeFromCodeCoverage]
	public override int ArgumentCount
	{
		 get { } //Length: 39
	}

	public Expression Expression
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
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal InvocationExpression(Expression expression, Type returnType) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public override int get_ArgumentCount() { }

	[CompilerGenerated]
	public Expression get_Expression() { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	[ExcludeFromCodeCoverage]
	public override Expression GetArgument(int index) { }

	[ExcludeFromCodeCoverage]
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }

}

