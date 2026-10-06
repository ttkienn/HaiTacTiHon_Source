namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LabelScopeInfo, LabelScopeInfo> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal LabelScopeInfo <ValidateJump>b__9_0(LabelScopeInfo b) { }

	}

	private readonly LabelTarget _node; //Field offset: 0x10
	private BranchLabel _label; //Field offset: 0x18
	private object _definitions; //Field offset: 0x20
	private readonly List<LabelScopeInfo> _references; //Field offset: 0x28
	private bool _acrossBlockJump; //Field offset: 0x30

	private bool HasDefinitions
	{
		private get { } //Length: 9
	}

	private bool HasMultipleDefinitions
	{
		private get { } //Length: 130
	}

	internal LabelInfo(LabelTarget node) { }

	private void AddDefinition(LabelScopeInfo scope) { }

	internal static T CommonNode(T first, T second, Func<T, T> parent) { }

	internal void Define(LabelScopeInfo block) { }

	private bool DefinedIn(LabelScopeInfo scope) { }

	private void EnsureLabel(LightCompiler compiler) { }

	private LabelScopeInfo FirstDefinition() { }

	private bool get_HasDefinitions() { }

	private bool get_HasMultipleDefinitions() { }

	internal BranchLabel GetLabel(LightCompiler compiler) { }

	internal void Reference(LabelScopeInfo block) { }

	internal void ValidateFinish() { }

	private void ValidateJump(LabelScopeInfo reference) { }

}

