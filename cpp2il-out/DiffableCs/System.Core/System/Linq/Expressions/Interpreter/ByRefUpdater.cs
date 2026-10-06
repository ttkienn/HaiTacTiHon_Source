namespace System.Linq.Expressions.Interpreter;

internal abstract class ByRefUpdater
{
	public readonly int ArgumentIndex; //Field offset: 0x10

	public ByRefUpdater(int argumentIndex) { }

	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }

	public abstract void Update(InterpretedFrame frame, object value) { }

}

