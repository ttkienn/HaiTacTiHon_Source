namespace System.Linq.Expressions.Interpreter;

internal abstract class NegateCheckedInstruction : Instruction
{
	private sealed class NegateCheckedInt16 : NegateCheckedInstruction
	{

		public NegateCheckedInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NegateCheckedInt32 : NegateCheckedInstruction
	{

		public NegateCheckedInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NegateCheckedInt64 : NegateCheckedInstruction
	{

		public NegateCheckedInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_Int16; //Field offset: 0x0
	private static Instruction s_Int32; //Field offset: 0x8
	private static Instruction s_Int64; //Field offset: 0x10

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
		 get { } //Length: 6
	}

	private NegateCheckedInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

