namespace System.Linq.Expressions.Interpreter;

internal abstract class OrInstruction : Instruction
{
	private sealed class OrBoolean : OrInstruction
	{

		public OrBoolean() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrByte : OrInstruction
	{

		public OrByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrInt16 : OrInstruction
	{

		public OrInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrInt32 : OrInstruction
	{

		public OrInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrInt64 : OrInstruction
	{

		public OrInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrSByte : OrInstruction
	{

		public OrSByte() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrUInt16 : OrInstruction
	{

		public OrUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrUInt32 : OrInstruction
	{

		public OrUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class OrUInt64 : OrInstruction
	{

		public OrUInt64() { }

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

	private OrInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

