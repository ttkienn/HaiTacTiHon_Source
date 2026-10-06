namespace System.Linq.Expressions.Interpreter;

internal abstract class DivInstruction : Instruction
{
	private sealed class DivDouble : DivInstruction
	{

		public DivDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivInt16 : DivInstruction
	{

		public DivInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivInt32 : DivInstruction
	{

		public DivInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivInt64 : DivInstruction
	{

		public DivInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivSingle : DivInstruction
	{

		public DivSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivUInt16 : DivInstruction
	{

		public DivUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivUInt32 : DivInstruction
	{

		public DivUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class DivUInt64 : DivInstruction
	{

		public DivUInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static Instruction s_Int16; //Field offset: 0x0
	private static Instruction s_Int32; //Field offset: 0x8
	private static Instruction s_Int64; //Field offset: 0x10
	private static Instruction s_UInt16; //Field offset: 0x18
	private static Instruction s_UInt32; //Field offset: 0x20
	private static Instruction s_UInt64; //Field offset: 0x28
	private static Instruction s_Single; //Field offset: 0x30
	private static Instruction s_Double; //Field offset: 0x38

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

	private DivInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

