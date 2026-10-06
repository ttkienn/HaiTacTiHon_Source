namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterFaultInstruction : IndexedBranchInstruction
{
	private static readonly EnterFaultInstruction[] s_cache; //Field offset: 0x0

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	private static EnterFaultInstruction() { }

	private EnterFaultInstruction(int labelIndex) { }

	internal static EnterFaultInstruction Create(int labelIndex) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

