namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction
{
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; //Field offset: 0x0
	private readonly bool _hasValue; //Field offset: 0x18

	public virtual int ConsumedStack
	{
		 get { } //Length: 9
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 9
	}

	private static LeaveExceptionHandlerInstruction() { }

	private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue) { }

	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

