namespace System.Linq.Expressions.Interpreter;

internal class BranchInstruction : OffsetInstruction
{
	private static Instruction[][][] s_caches; //Field offset: 0x0
	internal readonly bool _hasResult; //Field offset: 0x18
	internal readonly bool _hasValue; //Field offset: 0x19

	public virtual Instruction[] Cache
	{
		 get { } //Length: 691
	}

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

	internal BranchInstruction() { }

	public BranchInstruction(bool hasResult, bool hasValue) { }

	public virtual Instruction[] get_Cache() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

