namespace System.Linq.Expressions.Interpreter;

internal abstract class LeftShiftInstruction : Instruction
{
	private sealed class LeftShiftByte : LeftShiftInstruction
	{

		public LeftShiftByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftInt16 : LeftShiftInstruction
	{

		public LeftShiftInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftInt32 : LeftShiftInstruction
	{

		public LeftShiftInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftInt64 : LeftShiftInstruction
	{

		public LeftShiftInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftSByte : LeftShiftInstruction
	{

		public LeftShiftSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftUInt16 : LeftShiftInstruction
	{

		public LeftShiftUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftUInt32 : LeftShiftInstruction
	{

		public LeftShiftUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LeftShiftUInt64 : LeftShiftInstruction
	{

		public LeftShiftUInt64() { }

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

	private LeftShiftInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

