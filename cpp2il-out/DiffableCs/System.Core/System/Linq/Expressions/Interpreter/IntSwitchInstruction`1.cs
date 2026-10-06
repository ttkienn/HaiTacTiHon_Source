namespace System.Linq.Expressions.Interpreter;

internal sealed class IntSwitchInstruction : Instruction
{
	private readonly Dictionary<T, Int32> _cases; //Field offset: 0x0

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	internal IntSwitchInstruction`1(Dictionary<T, Int32> cases) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

