namespace System.Linq.Expressions.Interpreter;

internal abstract class CastInstruction : Instruction
{
	private abstract class CastInstructionNoT : CastInstruction
	{
		private sealed class Ref : CastInstructionNoT
		{

			public Ref(Type t) { }

			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		private sealed class Value : CastInstructionNoT
		{

			public Value(Type t) { }

			protected virtual void ConvertNull(InterpretedFrame frame) { }

		}

		private readonly Type _t; //Field offset: 0x10

		protected CastInstructionNoT(Type t) { }

		protected abstract void ConvertNull(InterpretedFrame frame) { }

		public static CastInstruction Create(Type t) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class CastInstructionT : CastInstruction
	{

		public CastInstructionT`1() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static CastInstruction s_Boolean; //Field offset: 0x0
	private static CastInstruction s_Byte; //Field offset: 0x8
	private static CastInstruction s_Char; //Field offset: 0x10
	private static CastInstruction s_DateTime; //Field offset: 0x18
	private static CastInstruction s_Decimal; //Field offset: 0x20
	private static CastInstruction s_Double; //Field offset: 0x28
	private static CastInstruction s_Int16; //Field offset: 0x30
	private static CastInstruction s_Int32; //Field offset: 0x38
	private static CastInstruction s_Int64; //Field offset: 0x40
	private static CastInstruction s_SByte; //Field offset: 0x48
	private static CastInstruction s_Single; //Field offset: 0x50
	private static CastInstruction s_String; //Field offset: 0x58
	private static CastInstruction s_UInt16; //Field offset: 0x60
	private static CastInstruction s_UInt32; //Field offset: 0x68
	private static CastInstruction s_UInt64; //Field offset: 0x70

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

	protected CastInstruction() { }

	public static Instruction Create(Type t) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

