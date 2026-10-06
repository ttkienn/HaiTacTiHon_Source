namespace System.Linq.Expressions.Interpreter;

internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction
{
	private TryFaultHandler _tryHandler; //Field offset: 0x18

	internal TryFaultHandler Handler
	{
		internal get { } //Length: 5
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedContinuations
	{
		 get { } //Length: 6
	}

	internal EnterTryFaultInstruction(int targetIndex) { }

	internal TryFaultHandler get_Handler() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedContinuations() { }

	public virtual int Run(InterpretedFrame frame) { }

	internal void SetTryHandler(TryFaultHandler tryHandler) { }

}

