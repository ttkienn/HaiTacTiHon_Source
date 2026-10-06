namespace System.Linq.Expressions.Interpreter;

internal abstract class NullableMethodCallInstruction : Instruction
{
	private sealed class EqualsClass : NullableMethodCallInstruction
	{

		public virtual int ConsumedStack
		{
			 get { } //Length: 6
		}

		public EqualsClass() { }

		public virtual int get_ConsumedStack() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetHashCodeClass : NullableMethodCallInstruction
	{

		public GetHashCodeClass() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetValue : NullableMethodCallInstruction
	{

		public GetValue() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetValueOrDefault : NullableMethodCallInstruction
	{
		private readonly Type _defaultValueType; //Field offset: 0x10

		public GetValueOrDefault(MethodInfo mi) { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class GetValueOrDefault1 : NullableMethodCallInstruction
	{

		public virtual int ConsumedStack
		{
			 get { } //Length: 6
		}

		public GetValueOrDefault1() { }

		public virtual int get_ConsumedStack() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class HasValue : NullableMethodCallInstruction
	{

		public HasValue() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private sealed class ToStringClass : NullableMethodCallInstruction
	{

		public ToStringClass() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	private static NullableMethodCallInstruction s_hasValue; //Field offset: 0x0
	private static NullableMethodCallInstruction s_value; //Field offset: 0x8
	private static NullableMethodCallInstruction s_equals; //Field offset: 0x10
	private static NullableMethodCallInstruction s_getHashCode; //Field offset: 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; //Field offset: 0x20
	private static NullableMethodCallInstruction s_toString; //Field offset: 0x28

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

	private NullableMethodCallInstruction() { }

	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	public static Instruction CreateGetValue() { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

}

