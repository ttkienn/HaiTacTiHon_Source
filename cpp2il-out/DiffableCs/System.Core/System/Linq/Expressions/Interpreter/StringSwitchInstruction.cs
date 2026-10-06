namespace System.Linq.Expressions.Interpreter;

internal sealed class StringSwitchInstruction : Instruction
{
	private readonly Dictionary<String, Int32> _cases; //Field offset: 0x10
	private readonly StrongBox<Int32> _nullCase; //Field offset: 0x18

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	internal StringSwitchInstruction(Dictionary<String, Int32> cases, StrongBox<Int32> nullCase) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

