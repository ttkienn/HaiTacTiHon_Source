namespace System.Linq.Expressions.Interpreter;

internal abstract class ModuloInstruction : Instruction
{
	private sealed class ModuloDouble : ModuloInstruction
	{

		public ModuloDouble() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloInt16 : ModuloInstruction
	{

		public ModuloInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloInt32 : ModuloInstruction
	{

		public ModuloInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloInt64 : ModuloInstruction
	{

		public ModuloInt64() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloSingle : ModuloInstruction
	{

		public ModuloSingle() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloUInt16 : ModuloInstruction
	{

		public ModuloUInt16() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloUInt32 : ModuloInstruction
	{

		public ModuloUInt32() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ModuloUInt64 : ModuloInstruction
	{

		public ModuloUInt64() { }

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

	private ModuloInstruction() { }

	public static Instruction Create(Type type) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

