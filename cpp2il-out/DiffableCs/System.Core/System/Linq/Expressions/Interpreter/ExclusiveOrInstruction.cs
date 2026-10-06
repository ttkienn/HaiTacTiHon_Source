namespace System.Linq.Expressions.Interpreter;

internal abstract class ExclusiveOrInstruction : Instruction
{
	private sealed class ExclusiveOrBoolean : ExclusiveOrInstruction
	{

		public ExclusiveOrBoolean() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrByte : ExclusiveOrInstruction
	{

		public ExclusiveOrByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrInt16 : ExclusiveOrInstruction
	{

		public ExclusiveOrInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrInt32 : ExclusiveOrInstruction
	{

		public ExclusiveOrInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrInt64 : ExclusiveOrInstruction
	{

		public ExclusiveOrInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrSByte : ExclusiveOrInstruction
	{

		public ExclusiveOrSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction
	{

		public ExclusiveOrUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction
	{

		public ExclusiveOrUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction
	{

		public ExclusiveOrUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_SByte; //Field offset: 0x0
	private static Instruction s_Int16; //Field offset: 0x8
	private static Instruction s_Int32; //Field offset: 0x10
	private static Instruction s_Int64; //Field offset: 0x18
	private static Instruction s_Byte; //Field offset: 0x20
	private static Instruction s_UInt16; //Field offset: 0x28
	private static Instruction s_UInt32; //Field offset: 0x30
	private static Instruction s_UInt64; //Field offset: 0x38
	private static Instruction s_Boolean; //Field offset: 0x40

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

	private ExclusiveOrInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

