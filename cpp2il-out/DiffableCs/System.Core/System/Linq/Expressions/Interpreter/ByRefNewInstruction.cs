namespace System.Linq.Expressions.Interpreter;

internal class ByRefNewInstruction : NewInstruction
{
	private readonly ByRefUpdater[] _byrefArgs; //Field offset: 0x20

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	internal ByRefNewInstruction(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

