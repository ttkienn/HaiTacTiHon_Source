namespace System.Linq.Expressions.Interpreter;

internal sealed class LeaveExceptionFilterInstruction : Instruction
{
	internal static readonly LeaveExceptionFilterInstruction Instance; //Field offset: 0x0

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	private static LeaveExceptionFilterInstruction() { }

	private LeaveExceptionFilterInstruction() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	[ExcludeFromCodeCoverage]
	public virtual int Run(InterpretedFrame frame) { }

}

