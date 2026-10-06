namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
{

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	internal StoreLocalInstruction(int index) { }

	public override Instruction BoxIfIndexMatches(int index) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

