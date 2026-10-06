namespace System.Linq.Expressions.Interpreter;

internal abstract class InitializeLocalInstruction : LocalAccessInstruction
{
	public sealed class ImmutableBox : InitializeLocalInstruction
	{
		private readonly object _defaultValue; //Field offset: 0x18

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal ImmutableBox(int index, object defaultValue) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class ImmutableRefBox : InitializeLocalInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal ImmutableRefBox(int index) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		private readonly object _defaultValue; //Field offset: 0x18

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal ImmutableValue(int index, object defaultValue) { }

		public override Instruction BoxIfIndexMatches(int index) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class MutableBox : InitializeLocalInstruction
	{
		private readonly Type _type; //Field offset: 0x18

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal MutableBox(int index, Type type) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
	{
		private readonly Type _type; //Field offset: 0x18

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal MutableValue(int index, Type type) { }

		public override Instruction BoxIfIndexMatches(int index) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal Parameter(int index) { }

		public override Instruction BoxIfIndexMatches(int index) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class ParameterBox : InitializeLocalInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		public ParameterBox(int index) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}

	public sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
	{

		public virtual string InstructionName
		{
			 get { } //Length: 44
		}

		internal Reference(int index) { }

		public override Instruction BoxIfIndexMatches(int index) { }

		public virtual string get_InstructionName() { }

		public virtual int Run(InterpretedFrame frame) { }

	}


	internal InitializeLocalInstruction(int index) { }

}

