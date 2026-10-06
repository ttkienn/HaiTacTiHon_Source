namespace System.Linq.Expressions.Interpreter;

internal abstract class MulInstruction : Instruction
{
	private sealed class MulDouble : MulInstruction
	{

		public MulDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulInt16 : MulInstruction
	{

		public MulInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulInt32 : MulInstruction
	{

		public MulInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulInt64 : MulInstruction
	{

		public MulInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulSingle : MulInstruction
	{

		public MulSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulUInt16 : MulInstruction
	{

		public MulUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulUInt32 : MulInstruction
	{

		public MulUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulUInt64 : MulInstruction
	{

		public MulUInt64() { }

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

	private MulInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

