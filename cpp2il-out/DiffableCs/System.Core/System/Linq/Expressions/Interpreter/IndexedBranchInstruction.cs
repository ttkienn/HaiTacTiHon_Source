namespace System.Linq.Expressions.Interpreter;

internal abstract class IndexedBranchInstruction : Instruction
{
	internal readonly int _labelIndex; //Field offset: 0x10

	public IndexedBranchInstruction(int labelIndex) { }

	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	public virtual string ToDebugString(int instructionIndex, object cookie, Func<Int32, Int32> labelIndexer, IReadOnlyList<Object> objects) { }

	public virtual string ToString() { }

}

