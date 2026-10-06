namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
public sealed class SwitchExpression : Expression
{
	[CompilerGenerated]
	private readonly Expression <SwitchValue>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Expression <DefaultBody>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Comparison>k__BackingField; //Field offset: 0x28

	public ReadOnlyCollection<SwitchCase> Cases
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MethodInfo Comparison
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expression DefaultBody
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expression SwitchValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CompilerGenerated]
	public MethodInfo get_Comparison() { }

	[CompilerGenerated]
	public Expression get_DefaultBody() { }

	[CompilerGenerated]
	public Expression get_SwitchValue() { }

}

