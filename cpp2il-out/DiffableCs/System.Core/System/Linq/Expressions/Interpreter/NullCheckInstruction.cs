namespace System.Linq.Expressions.Interpreter;

internal sealed class NullCheckInstruction : Instruction
{
	public static readonly Instruction Instance; //Field offset: 0x0

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

	private static NullCheckInstruction() { }

	private NullCheckInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

