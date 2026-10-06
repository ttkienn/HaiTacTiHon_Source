namespace System.Linq.Expressions.Interpreter;

internal sealed class CoalescingBranchInstruction : OffsetInstruction
{
	private static Instruction[] s_cache; //Field offset: 0x0

	public virtual Instruction[] Cache
	{
		 get { } //Length: 142
	}

	public virtual int ConsumedStack
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

	public CoalescingBranchInstruction() { }

	public virtual Instruction[] get_Cache() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

