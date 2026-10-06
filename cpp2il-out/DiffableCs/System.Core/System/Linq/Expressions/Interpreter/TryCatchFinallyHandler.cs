namespace System.Linq.Expressions.Interpreter;

internal sealed class TryCatchFinallyHandler
{
	internal readonly int TryStartIndex; //Field offset: 0x10
	internal readonly int TryEndIndex; //Field offset: 0x14
	internal readonly int FinallyStartIndex; //Field offset: 0x18
	internal readonly int FinallyEndIndex; //Field offset: 0x1C
	internal readonly int GotoEndTargetIndex; //Field offset: 0x20
	private readonly ExceptionHandler[] _handlers; //Field offset: 0x28

	internal ExceptionHandler[] Handlers
	{
		internal get { } //Length: 5
	}

	internal bool IsCatchBlockExist
	{
		internal get { } //Length: 9
	}

	internal bool IsFinallyBlockExist
	{
		internal get { } //Length: 11
	}

	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }

	internal ExceptionHandler[] get_Handlers() { }

	internal bool get_IsCatchBlockExist() { }

	internal bool get_IsFinallyBlockExist() { }

	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

}

