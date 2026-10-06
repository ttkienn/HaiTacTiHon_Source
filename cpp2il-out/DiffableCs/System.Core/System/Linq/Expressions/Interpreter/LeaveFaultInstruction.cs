namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveFaultInstruction : Instruction
{
	internal static readonly Instruction Instance; //Field offset: 0x0

	public virtual int ConsumedContinuations
	{
		 get { } //Length: 6
	}

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	private static LeaveFaultInstruction() { }

	private LeaveFaultInstruction() { }

	public virtual int get_ConsumedContinuations() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

