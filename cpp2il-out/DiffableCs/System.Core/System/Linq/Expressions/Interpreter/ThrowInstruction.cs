namespace System.Linq.Expressions.Interpreter;

internal sealed class ThrowInstruction : Instruction
{
	internal static readonly ThrowInstruction Throw; //Field offset: 0x0
	internal static readonly ThrowInstruction VoidThrow; //Field offset: 0x8
	internal static readonly ThrowInstruction Rethrow; //Field offset: 0x10
	internal static readonly ThrowInstruction VoidRethrow; //Field offset: 0x18
	private readonly bool _hasResult; //Field offset: 0x10
	private readonly bool _rethrow; //Field offset: 0x11

	public virtual int ConsumedStack
	{
		 get { } //Length: 6
	}

	public virtual string InstructionName
	{
		 get { } //Length: 44
	}

	public virtual int ProducedStack
	{
		 get { } //Length: 9
	}

	private static ThrowInstruction() { }

	private ThrowInstruction(bool hasResult, bool isRethrow) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

	private static Exception WrapThrownObject(object thrown) { }

}

