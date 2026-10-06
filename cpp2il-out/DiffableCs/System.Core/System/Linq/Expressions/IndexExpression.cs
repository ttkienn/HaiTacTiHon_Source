namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
public sealed class IndexExpression : Expression, IArgumentProvider
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Expression <Object>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly PropertyInfo <Indexer>k__BackingField; //Field offset: 0x20

	public override int ArgumentCount
	{
		 get { } //Length: 70
	}

	public PropertyInfo Indexer
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public Expression Object
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public virtual Type Type
	{
		 get { } //Length: 127
	}

	internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public override int get_ArgumentCount() { }

	[CompilerGenerated]
	public PropertyInfo get_Indexer() { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public Expression get_Object() { }

	public virtual Type get_Type() { }

	public override Expression GetArgument(int index) { }

	internal Expression Rewrite(Expression instance, Expression[] arguments) { }

}

