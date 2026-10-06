namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
internal struct RuntimeLabel
{
	public readonly int Index; //Field offset: 0x0
	public readonly int StackDepth; //Field offset: 0x4
	public readonly int ContinuationStackDepth; //Field offset: 0x8

	public RuntimeLabel(int index, int continuationStackDepth, int stackDepth) { }

	public virtual string ToString() { }

}

