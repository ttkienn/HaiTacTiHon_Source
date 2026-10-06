namespace System.Linq.Expressions.Interpreter;

internal sealed class LabelScopeInfo
{
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; //Field offset: 0x10
	internal readonly LabelScopeKind Kind; //Field offset: 0x18
	internal readonly LabelScopeInfo Parent; //Field offset: 0x20

	internal bool CanJumpInto
	{
		internal get { } //Length: 8
	}

	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind) { }

	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }

	internal bool ContainsTarget(LabelTarget target) { }

	internal bool get_CanJumpInto() { }

	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

}

