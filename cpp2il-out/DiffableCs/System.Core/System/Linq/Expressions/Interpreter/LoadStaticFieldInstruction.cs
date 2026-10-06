namespace System.Linq.Expressions.Interpreter;

internal sealed class LoadStaticFieldInstruction : FieldInstruction
{

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	public LoadStaticFieldInstruction(FieldInfo field) { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

