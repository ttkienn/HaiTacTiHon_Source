namespace System.Linq.Expressions.Interpreter;

internal sealed class RuntimeVariablesInstruction : Instruction
{
	private readonly int _count; //Field offset: 0x10

	public virtual int ConsumedStack
	{
		 get { } //Length: 191
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	public RuntimeVariablesInstruction(int count) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

