namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
{

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	internal StoreLocalBoxedInstruction(int index) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

