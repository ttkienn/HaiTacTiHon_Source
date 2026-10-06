namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterExceptionFilterInstruction : Instruction
{
	internal static readonly EnterExceptionFilterInstruction Instance; //Field offset: 0x0

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 6
	}

	private static EnterExceptionFilterInstruction() { }

	private EnterExceptionFilterInstruction() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	public virtual int Run(InterpretedFrame frame) { }

}

