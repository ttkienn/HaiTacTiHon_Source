namespace System.Linq.Expressions.Interpreter;

internal sealed class NewArrayBoundsInstruction : Instruction
{
	private readonly Type _elementType; //Field offset: 0x10
	private readonly int _rank; //Field offset: 0x18

	public virtual int ConsumedStack
	{
		 get { } //Length: 4
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	internal NewArrayBoundsInstruction(Type elementType, int rank) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

