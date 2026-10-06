namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveFinallyInstruction : Instruction
{
	internal static readonly Instruction Instance; //Field offset: 0x0

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	private static LeaveFinallyInstruction() { }

	private LeaveFinallyInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

