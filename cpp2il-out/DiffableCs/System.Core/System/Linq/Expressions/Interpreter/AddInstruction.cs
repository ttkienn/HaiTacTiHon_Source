namespace System.Linq.Expressions.Interpreter;

internal abstract class AddInstruction : Instruction
{
	private sealed class AddDouble : AddInstruction
	{

		public AddDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddInt16 : AddInstruction
	{

		public AddInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddInt32 : AddInstruction
	{

		public AddInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddInt64 : AddInstruction
	{

		public AddInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddSingle : AddInstruction
	{

		public AddSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddUInt16 : AddInstruction
	{

		public AddUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddUInt32 : AddInstruction
	{

		public AddUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddUInt64 : AddInstruction
	{

		public AddUInt64() { }

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

	private AddInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

