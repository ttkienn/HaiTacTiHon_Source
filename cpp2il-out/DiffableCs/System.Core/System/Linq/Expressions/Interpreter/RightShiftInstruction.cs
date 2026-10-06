namespace System.Linq.Expressions.Interpreter;

internal abstract class RightShiftInstruction : Instruction
{
	private sealed class RightShiftByte : RightShiftInstruction
	{

		public RightShiftByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftInt16 : RightShiftInstruction
	{

		public RightShiftInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftInt32 : RightShiftInstruction
	{

		public RightShiftInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftInt64 : RightShiftInstruction
	{

		public RightShiftInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftSByte : RightShiftInstruction
	{

		public RightShiftSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftUInt16 : RightShiftInstruction
	{

		public RightShiftUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftUInt32 : RightShiftInstruction
	{

		public RightShiftUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class RightShiftUInt64 : RightShiftInstruction
	{

		public RightShiftUInt64() { }

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

	private RightShiftInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

