namespace System.Linq.Expressions;

internal sealed class ScopeWithType : ScopeN
{
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; //Field offset: 0x20

	public virtual Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type) { }

	[CompilerGenerated]
	public virtual Type get_Type() { }

	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

}

