namespace System.Linq.Expressions.Interpreter;

internal sealed class BranchLabel
{
	private int _targetIndex; //Field offset: 0x10
	private int _stackDepth; //Field offset: 0x14
	private int _continuationStackDepth; //Field offset: 0x18
	private List<Int32> _forwardBranchFixups; //Field offset: 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; //Field offset: 0x28

	internal bool HasRuntimeLabel
	{
		internal get { } //Length: 11
	}

	internal int LabelIndex
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal int TargetIndex
	{
		internal get { } //Length: 191
	}

	public BranchLabel() { }

	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	internal bool get_HasRuntimeLabel() { }

	[CompilerGenerated]
	internal int get_LabelIndex() { }

	internal int get_TargetIndex() { }

	internal void Mark(InstructionList instructions) { }

	[CompilerGenerated]
	internal void set_LabelIndex(int value) { }

	internal RuntimeLabel ToRuntimeLabel() { }

}

