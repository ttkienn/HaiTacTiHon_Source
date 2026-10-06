namespace System.Linq.Expressions.Interpreter;

internal abstract class FieldInstruction : Instruction
{
	protected readonly FieldInfo _field; //Field offset: 0x10

	public FieldInstruction(FieldInfo field) { }

	public virtual string ToString() { }

}

