namespace System.Linq.Expressions.Interpreter;

internal abstract class AndInstruction : Instruction
{
	private sealed class AndBoolean : AndInstruction
	{

		public AndBoolean() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndByte : AndInstruction
	{

		public AndByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndInt16 : AndInstruction
	{

		public AndInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndInt32 : AndInstruction
	{

		public AndInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndInt64 : AndInstruction
	{

		public AndInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndSByte : AndInstruction
	{

		public AndSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndUInt16 : AndInstruction
	{

		public AndUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndUInt32 : AndInstruction
	{

		public AndUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AndUInt64 : AndInstruction
	{

		public AndUInt64() { }

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

	private AndInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

