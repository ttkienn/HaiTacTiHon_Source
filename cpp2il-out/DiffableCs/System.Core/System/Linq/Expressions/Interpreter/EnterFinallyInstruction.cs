namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterFinallyInstruction : IndexedBranchInstruction
{
	private static readonly EnterFinallyInstruction[] s_cache; //Field offset: 0x0

	public virtual int ConsumedContinuations
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	private static EnterFinallyInstruction() { }

	private EnterFinallyInstruction(int labelIndex) { }

	internal static EnterFinallyInstruction Create(int labelIndex) { }

	public virtual int get_ConsumedContinuations() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

