namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(DefaultExpressionProxy))]
public sealed class DefaultExpression : Expression
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x10

	public virtual ExpressionType NodeType
	{
		 get { } //Length: 6
	}

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal DefaultExpression(Type type) { }

	protected private virtual Expression Accept(ExpressionVisitor visitor) { }

	public virtual ExpressionType get_NodeType() { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

}

