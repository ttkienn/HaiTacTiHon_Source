namespace System.Linq.Expressions.Interpreter;

internal sealed class CreateDelegateInstruction : Instruction
{
	private readonly LightDelegateCreator _creator; //Field offset: 0x10

	public virtual int ConsumedStack
	{
		 get { } //Length: 38
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	internal CreateDelegateInstruction(LightDelegateCreator delegateCreator) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

