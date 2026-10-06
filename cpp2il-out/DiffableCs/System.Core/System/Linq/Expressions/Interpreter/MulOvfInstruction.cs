namespace System.Linq.Expressions.Interpreter;

internal abstract class MulOvfInstruction : Instruction
{
	private sealed class MulOvfInt16 : MulOvfInstruction
	{

		public MulOvfInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulOvfInt32 : MulOvfInstruction
	{

		public MulOvfInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulOvfInt64 : MulOvfInstruction
	{

		public MulOvfInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulOvfUInt16 : MulOvfInstruction
	{

		public MulOvfUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulOvfUInt32 : MulOvfInstruction
	{

		public MulOvfUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class MulOvfUInt64 : MulOvfInstruction
	{

		public MulOvfUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_Int16; //Field offset: 0x0
	private static Instruction s_Int32; //Field offset: 0x8
	private static Instruction s_Int64; //Field offset: 0x10
	private static Instruction s_UInt16; //Field offset: 0x18
	private static Instruction s_UInt32; //Field offset: 0x20
	private static Instruction s_UInt64; //Field offset: 0x28

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

	private MulOvfInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

