namespace System.Linq.Expressions.Interpreter;

internal sealed class ExceptionFilter
{
	public readonly int LabelIndex; //Field offset: 0x10
	public readonly int StartIndex; //Field offset: 0x14
	public readonly int EndIndex; //Field offset: 0x18

	internal ExceptionFilter(int labelIndex, int start, int end) { }

}

