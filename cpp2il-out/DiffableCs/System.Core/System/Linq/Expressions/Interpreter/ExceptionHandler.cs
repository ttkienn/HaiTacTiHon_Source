namespace System.Linq.Expressions.Interpreter;

internal sealed class ExceptionHandler
{
	private readonly Type _exceptionType; //Field offset: 0x10
	public readonly int LabelIndex; //Field offset: 0x18
	public readonly int HandlerStartIndex; //Field offset: 0x1C
	public readonly int HandlerEndIndex; //Field offset: 0x20
	public readonly ExceptionFilter Filter; //Field offset: 0x28

	internal ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	public bool Matches(Type exceptionType) { }

	public virtual string ToString() { }

}

