namespace System.Linq.Expressions.Interpreter;

internal sealed class GotoInstruction : IndexedBranchInstruction
{
	private static readonly GotoInstruction[] s_cache; //Field offset: 0x0
	private readonly bool _hasResult; //Field offset: 0x18
	private readonly bool _hasValue; //Field offset: 0x19
	private readonly bool _labelTargetGetsValue; //Field offset: 0x1A

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

	private static GotoInstruction() { }

	private GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

}

