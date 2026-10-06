namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(CatchBlockProxy))]
public sealed class CatchBlock
{
	[CompilerGenerated]
	private readonly ParameterExpression <Variable>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Type <Test>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly Expression <Filter>k__BackingField; //Field offset: 0x28

	public Expression Body
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Expression Filter
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type Test
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ParameterExpression Variable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal CatchBlock(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGenerated]
	public Expression get_Body() { }

	[CompilerGenerated]
	public Expression get_Filter() { }

	[CompilerGenerated]
	public Type get_Test() { }

	[CompilerGenerated]
	public ParameterExpression get_Variable() { }

	public virtual string ToString() { }

	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }

}

