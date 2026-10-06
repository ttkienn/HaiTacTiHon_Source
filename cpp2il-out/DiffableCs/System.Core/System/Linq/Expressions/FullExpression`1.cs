namespace System.Linq.Expressions;

internal sealed class FullExpression : ExpressionN<TDelegate>
{
	[CompilerGenerated]
	private readonly string <NameCore>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <TailCallCore>k__BackingField; //Field offset: 0x0

	internal virtual string NameCore
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal virtual bool TailCallCore
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public FullExpression`1(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }

	[CompilerGenerated]
	internal virtual string get_NameCore() { }

	[CompilerGenerated]
	internal virtual bool get_TailCallCore() { }

}

