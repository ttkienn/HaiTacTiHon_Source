namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
public class MethodCallExpression : Expression, IArgumentProvider
{
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; //Field offset: 0x10

	[ExcludeFromCodeCoverage]
	public override int ArgumentCount
	{
		 get { } //Length: 39
	}

	public MethodInfo Method
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
		 get { } //Length: 20
	}

	public virtual Type Type
	{
		 get { } //Length: 42
	}

	internal MethodCallExpression(MethodInfo method) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public override int get_ArgumentCount() { }

	[CompilerGenerated]
	public MethodInfo get_Method() { }

	public virtual ExpressionType get_NodeType() { }

	public Expression get_Object() { }

	public virtual Type get_Type() { }

	[ExcludeFromCodeCoverage]
	public override Expression GetArgument(int index) { }

	internal override Expression GetInstance() { }

	[ExcludeFromCodeCoverage]
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

}

