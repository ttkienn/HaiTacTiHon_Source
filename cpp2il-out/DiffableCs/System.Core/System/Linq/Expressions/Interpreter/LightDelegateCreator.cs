namespace System.Linq.Expressions.Interpreter;

internal sealed class LightDelegateCreator
{
	private readonly LambdaExpression _lambda; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; //Field offset: 0x18

	internal Interpreter Interpreter
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda) { }

	public Delegate CreateDelegate() { }

	internal Delegate CreateDelegate(IStrongBox[] closure) { }

	[CompilerGenerated]
	internal Interpreter get_Interpreter() { }

}

