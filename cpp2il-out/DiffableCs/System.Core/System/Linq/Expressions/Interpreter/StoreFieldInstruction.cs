namespace System.Linq.Expressions.Interpreter;

internal sealed class StoreFieldInstruction : FieldInstruction
{

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public StoreFieldInstruction(FieldInfo field) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int Run(InterpretedFrame frame) { }

}

