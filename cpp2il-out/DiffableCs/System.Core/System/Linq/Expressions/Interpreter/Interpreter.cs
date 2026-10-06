namespace System.Linq.Expressions.Interpreter;

internal sealed class Interpreter
{
	internal static readonly object NoValue; //Field offset: 0x0
	private readonly InstructionArray _instructions; //Field offset: 0x10
	internal readonly Object[] _objects; //Field offset: 0x38
	internal readonly RuntimeLabel[] _labels; //Field offset: 0x40
	internal readonly DebugInfo[] _debugInfos; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; //Field offset: 0x60

	internal int ClosureSize
	{
		internal get { } //Length: 71
	}

	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal InstructionArray Instructions
	{
		internal get { } //Length: 29
	}

	internal int LocalCount
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal string Name
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	private static Interpreter() { }

	internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	internal int get_ClosureSize() { }

	[CompilerGenerated]
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	internal int get_LocalCount() { }

	[CompilerGenerated]
	internal string get_Name() { }

	public void Run(InterpretedFrame frame) { }

}

