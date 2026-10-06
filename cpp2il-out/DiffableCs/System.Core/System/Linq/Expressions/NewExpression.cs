namespace System.Linq.Expressions;

[DebuggerTypeProxy(typeof(NewExpressionProxy))]
public class NewExpression : Expression
{
	private IReadOnlyList<Expression> _arguments; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ConstructorInfo <Constructor>k__BackingField; //Field offset: 0x18

	public ConstructorInfo Constructor
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public ConstructorInfo get_Constructor() { }

	public override Expression GetArgument(int index) { }

}

