namespace System.Linq.Expressions.Interpreter;

internal abstract class NotEqualInstruction : Instruction
{
	private sealed class NotEqualBoolean : NotEqualInstruction
	{

		public NotEqualBoolean() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualByte : NotEqualInstruction
	{

		public NotEqualByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualByteLiftedToNull : NotEqualInstruction
	{

		public NotEqualByteLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualChar : NotEqualInstruction
	{

		public NotEqualChar() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualCharLiftedToNull : NotEqualInstruction
	{

		public NotEqualCharLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualDouble : NotEqualInstruction
	{

		public NotEqualDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction
	{

		public NotEqualDoubleLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualInt16 : NotEqualInstruction
	{

		public NotEqualInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualInt16LiftedToNull : NotEqualInstruction
	{

		public NotEqualInt16LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualInt32 : NotEqualInstruction
	{

		public NotEqualInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualInt32LiftedToNull : NotEqualInstruction
	{

		public NotEqualInt32LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualInt64 : NotEqualInstruction
	{

		public NotEqualInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualInt64LiftedToNull : NotEqualInstruction
	{

		public NotEqualInt64LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualReference : NotEqualInstruction
	{

		public NotEqualReference() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualSByte : NotEqualInstruction
	{

		public NotEqualSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualSByteLiftedToNull : NotEqualInstruction
	{

		public NotEqualSByteLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualSingle : NotEqualInstruction
	{

		public NotEqualSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualSingleLiftedToNull : NotEqualInstruction
	{

		public NotEqualSingleLiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualUInt16 : NotEqualInstruction
	{

		public NotEqualUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction
	{

		public NotEqualUInt16LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualUInt32 : NotEqualInstruction
	{

		public NotEqualUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction
	{

		public NotEqualUInt32LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualUInt64 : NotEqualInstruction
	{

		public NotEqualUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction
	{

		public NotEqualUInt64LiftedToNull() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_reference; //Field offset: 0x0
	private static Instruction s_Boolean; //Field offset: 0x8
	private static Instruction s_SByte; //Field offset: 0x10
	private static Instruction s_Int16; //Field offset: 0x18
	private static Instruction s_Char; //Field offset: 0x20
	private static Instruction s_Int32; //Field offset: 0x28
	private static Instruction s_Int64; //Field offset: 0x30
	private static Instruction s_Byte; //Field offset: 0x38
	private static Instruction s_UInt16; //Field offset: 0x40
	private static Instruction s_UInt32; //Field offset: 0x48
	private static Instruction s_UInt64; //Field offset: 0x50
	private static Instruction s_Single; //Field offset: 0x58
	private static Instruction s_Double; //Field offset: 0x60
	private static Instruction s_SByteLiftedToNull; //Field offset: 0x68
	private static Instruction s_Int16LiftedToNull; //Field offset: 0x70
	private static Instruction s_CharLiftedToNull; //Field offset: 0x78
	private static Instruction s_Int32LiftedToNull; //Field offset: 0x80
	private static Instruction s_Int64LiftedToNull; //Field offset: 0x88
	private static Instruction s_ByteLiftedToNull; //Field offset: 0x90
	private static Instruction s_UInt16LiftedToNull; //Field offset: 0x98
	private static Instruction s_UInt32LiftedToNull; //Field offset: 0xA0
	private static Instruction s_UInt64LiftedToNull; //Field offset: 0xA8
	private static Instruction s_SingleLiftedToNull; //Field offset: 0xB0
	private static Instruction s_DoubleLiftedToNull; //Field offset: 0xB8

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

	private NotEqualInstruction() { }

	public static Instruction Create(Type type, bool liftedToNull) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

