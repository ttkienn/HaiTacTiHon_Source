namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterExceptionHandlerInstruction : Instruction
{
	internal static readonly EnterExceptionHandlerInstruction Void; //Field offset: 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; //Field offset: 0x8
	private readonly bool _hasValue; //Field offset: 0x10

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
		 get { } //Length: 6
	}

	private static EnterExceptionHandlerInstruction() { }

	private EnterExceptionHandlerInstruction(bool hasValue) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	public virtual int Run(InterpretedFrame frame) { }

}

