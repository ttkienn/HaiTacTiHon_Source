namespace System.Linq.Expressions.Interpreter;

internal abstract class SubOvfInstruction : Instruction
{
	private sealed class SubOvfInt16 : SubOvfInstruction
	{

		public SubOvfInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubOvfInt32 : SubOvfInstruction
	{

		public SubOvfInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubOvfInt64 : SubOvfInstruction
	{

		public SubOvfInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubOvfUInt16 : SubOvfInstruction
	{

		public SubOvfUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubOvfUInt32 : SubOvfInstruction
	{

		public SubOvfUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class SubOvfUInt64 : SubOvfInstruction
	{

		public SubOvfUInt64() { }

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

	private SubOvfInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

