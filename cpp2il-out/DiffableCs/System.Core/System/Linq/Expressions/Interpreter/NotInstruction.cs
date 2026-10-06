namespace System.Linq.Expressions.Interpreter;

internal abstract class NotInstruction : Instruction
{
	private sealed class NotBoolean : NotInstruction
	{

		public NotBoolean() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotByte : NotInstruction
	{

		public NotByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotInt16 : NotInstruction
	{

		public NotInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotInt32 : NotInstruction
	{

		public NotInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotInt64 : NotInstruction
	{

		public NotInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotSByte : NotInstruction
	{

		public NotSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotUInt16 : NotInstruction
	{

		public NotUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotUInt32 : NotInstruction
	{

		public NotUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotUInt64 : NotInstruction
	{

		public NotUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public static Instruction s_Boolean; //Field offset: 0x0
	public static Instruction s_Int64; //Field offset: 0x8
	public static Instruction s_Int32; //Field offset: 0x10
	public static Instruction s_Int16; //Field offset: 0x18
	public static Instruction s_UInt64; //Field offset: 0x20
	public static Instruction s_UInt32; //Field offset: 0x28
	public static Instruction s_UInt16; //Field offset: 0x30
	public static Instruction s_Byte; //Field offset: 0x38
	public static Instruction s_SByte; //Field offset: 0x40

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

	private NotInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

