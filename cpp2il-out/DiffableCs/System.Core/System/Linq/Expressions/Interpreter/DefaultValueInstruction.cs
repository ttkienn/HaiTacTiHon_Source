namespace System.Linq.Expressions.Interpreter;

internal sealed class DefaultValueInstruction : Instruction
{
	private readonly Type _type; //Field offset: 0x10

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	internal DefaultValueInstruction(Type type) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

	public virtual string ToString() { }

}

