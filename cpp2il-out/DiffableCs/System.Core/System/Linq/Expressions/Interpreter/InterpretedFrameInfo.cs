namespace System.Linq.Expressions.Interpreter;

[IsReadOnly]
internal struct InterpretedFrameInfo
{
	private readonly string _methodName; //Field offset: 0x0
	private readonly DebugInfo _debugInfo; //Field offset: 0x8

	public InterpretedFrameInfo(string methodName, DebugInfo info) { }

	public virtual string ToString() { }

}

