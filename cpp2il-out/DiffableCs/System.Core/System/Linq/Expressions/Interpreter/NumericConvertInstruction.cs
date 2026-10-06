namespace System.Linq.Expressions.Interpreter;

internal abstract class NumericConvertInstruction : Instruction
{
	public sealed class Checked : NumericConvertInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		public Checked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

		protected virtual object Convert(object obj) { }

		private object ConvertDouble(double obj) { }

		private object ConvertInt32(int obj) { }

		private object ConvertInt64(long obj) { }

		private object ConvertUInt64(ulong obj) { }

		public virtual string get_InstructionName() { }

	}

	public sealed class ToUnderlying : NumericConvertInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		public ToUnderlying(TypeCode to, bool isLiftedToNull) { }

		protected virtual object Convert(object obj) { }

		public virtual string get_InstructionName() { }

	}

	public sealed class Unchecked : NumericConvertInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		public Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

		protected virtual object Convert(object obj) { }

		private object ConvertDouble(double obj) { }

		private object ConvertInt32(int obj) { }

		private object ConvertInt64(long obj) { }

		private object ConvertUInt64(ulong obj) { }

		public virtual string get_InstructionName() { }

	}

	internal readonly TypeCode _from; //Field offset: 0x10
	internal readonly TypeCode _to; //Field offset: 0x14
	private readonly bool _isLiftedToNull; //Field offset: 0x18

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

	protected NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	protected abstract object Convert(object obj) { }

	public virtual int get_ConsumedStack() { }

	public virtual string get_InstructionName() { }

	public virtual int get_ProducedStack() { }

	public virtual int Run(InterpretedFrame frame) { }

	public virtual string ToString() { }

}

