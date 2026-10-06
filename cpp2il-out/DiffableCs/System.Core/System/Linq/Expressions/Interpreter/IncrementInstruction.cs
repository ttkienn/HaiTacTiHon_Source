namespace System.Linq.Expressions.Interpreter;

internal abstract class IncrementInstruction : Instruction
{
	private sealed class IncrementDouble : IncrementInstruction
	{

		public IncrementDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementInt16 : IncrementInstruction
	{

		public IncrementInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementInt32 : IncrementInstruction
	{

		public IncrementInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementInt64 : IncrementInstruction
	{

		public IncrementInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementSingle : IncrementInstruction
	{

		public IncrementSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementUInt16 : IncrementInstruction
	{

		public IncrementUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementUInt32 : IncrementInstruction
	{

		public IncrementUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class IncrementUInt64 : IncrementInstruction
	{

		public IncrementUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_Int16; //Field offset: 0x0
	private static Instruction s_Int32; //Field offset: 0x8
	private static Instruction s_Int64; //Field offset: 0x10
	private static Instruction s_UInt16; //Field offset: 0x18
	private static Instruction s_UInt32; //Field offset: 0x20
	private static Instruction s_UInt64; //Field offset: 0x28
	private static Instruction s_Single; //Field offset: 0x30
	private static Instruction s_Double; //Field offset: 0x38

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

	private IncrementInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

