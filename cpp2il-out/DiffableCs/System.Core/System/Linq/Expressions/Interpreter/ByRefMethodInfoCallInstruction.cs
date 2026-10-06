namespace System.Linq.Expressions.Interpreter;

internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
{
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x20

	public virtual int ProducedStack
	{
		 get { } //Length: 162
	}

	internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

