namespace System.Linq.Expressions.Interpreter;

internal abstract class AddOvfInstruction : Instruction
{
	private sealed class AddOvfInt16 : AddOvfInstruction
	{

		public AddOvfInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddOvfInt32 : AddOvfInstruction
	{

		public AddOvfInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddOvfInt64 : AddOvfInstruction
	{

		public AddOvfInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddOvfUInt16 : AddOvfInstruction
	{

		public AddOvfUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddOvfUInt32 : AddOvfInstruction
	{

		public AddOvfUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class AddOvfUInt64 : AddOvfInstruction
	{

		public AddOvfUInt64() { }

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

	private AddOvfInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

