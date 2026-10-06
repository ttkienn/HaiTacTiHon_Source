namespace System.Linq.Expressions.Interpreter;

internal abstract class DecrementInstruction : Instruction
{
	private sealed class DecrementDouble : DecrementInstruction
	{

		public DecrementDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementInt16 : DecrementInstruction
	{

		public DecrementInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementInt32 : DecrementInstruction
	{

		public DecrementInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementInt64 : DecrementInstruction
	{

		public DecrementInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementSingle : DecrementInstruction
	{

		public DecrementSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementUInt16 : DecrementInstruction
	{

		public DecrementUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementUInt32 : DecrementInstruction
	{

		public DecrementUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DecrementUInt64 : DecrementInstruction
	{

		public DecrementUInt64() { }

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

	private DecrementInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

