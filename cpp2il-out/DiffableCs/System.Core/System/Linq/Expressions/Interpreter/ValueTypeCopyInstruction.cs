namespace System.Linq.Expressions.Interpreter;

internal sealed class ValueTypeCopyInstruction : Instruction
{
	public static readonly ValueTypeCopyInstruction Instruction; //Field offset: 0x0

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

	private static ValueTypeCopyInstruction() { }

	public ValueTypeCopyInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

