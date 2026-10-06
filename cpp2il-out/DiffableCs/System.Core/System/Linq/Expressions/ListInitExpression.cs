namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
public sealed class ListInitExpression : Expression
{
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; //Field offset: 0x18

	public ReadOnlyCollection<ElementInit> Initializers
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NewExpression NewExpression
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public ReadOnlyCollection<ElementInit> get_Initializers() { }

	[CompilerGenerated]
	public NewExpression get_NewExpression() { }

}

