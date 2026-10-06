namespace System.Linq.Expressions.Interpreter;

internal abstract class LessThanOrEqualInstruction : Instruction
{
	private sealed class LessThanOrEqualByte : LessThanOrEqualInstruction
	{

		public LessThanOrEqualByte(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualChar : LessThanOrEqualInstruction
	{

		public LessThanOrEqualChar(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualDouble : LessThanOrEqualInstruction
	{

		public LessThanOrEqualDouble(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualInt16 : LessThanOrEqualInstruction
	{

		public LessThanOrEqualInt16(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualInt32 : LessThanOrEqualInstruction
	{

		public LessThanOrEqualInt32(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualInt64 : LessThanOrEqualInstruction
	{

		public LessThanOrEqualInt64(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualSByte : LessThanOrEqualInstruction
	{

		public LessThanOrEqualSByte(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualSingle : LessThanOrEqualInstruction
	{

		public LessThanOrEqualSingle(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
	{

		public LessThanOrEqualUInt16(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
	{

		public LessThanOrEqualUInt32(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
	{

		public LessThanOrEqualUInt64(object nullValue) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_SByte; //Field offset: 0x0
	private static Instruction s_Int16; //Field offset: 0x8
	private static Instruction s_Char; //Field offset: 0x10
	private static Instruction s_Int32; //Field offset: 0x18
	private static Instruction s_Int64; //Field offset: 0x20
	private static Instruction s_Byte; //Field offset: 0x28
	private static Instruction s_UInt16; //Field offset: 0x30
	private static Instruction s_UInt32; //Field offset: 0x38
	private static Instruction s_UInt64; //Field offset: 0x40
	private static Instruction s_Single; //Field offset: 0x48
	private static Instruction s_Double; //Field offset: 0x50
	private static Instruction s_liftedToNullSByte; //Field offset: 0x58
	private static Instruction s_liftedToNullInt16; //Field offset: 0x60
	private static Instruction s_liftedToNullChar; //Field offset: 0x68
	private static Instruction s_liftedToNullInt32; //Field offset: 0x70
	private static Instruction s_liftedToNullInt64; //Field offset: 0x78
	private static Instruction s_liftedToNullByte; //Field offset: 0x80
	private static Instruction s_liftedToNullUInt16; //Field offset: 0x88
	private static Instruction s_liftedToNullUInt32; //Field offset: 0x90
	private static Instruction s_liftedToNullUInt64; //Field offset: 0x98
	private static Instruction s_liftedToNullSingle; //Field offset: 0xA0
	private static Instruction s_liftedToNullDouble; //Field offset: 0xA8
	private readonly object _nullValue; //Field offset: 0x10

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

	private LessThanOrEqualInstruction(object nullValue) { }

	public static Instruction Create(Type type, bool liftedToNull = false) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

