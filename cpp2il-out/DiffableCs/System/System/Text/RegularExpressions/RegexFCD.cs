namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct RegexFCD
{
	private readonly List<RegexFC> _fcStack; //Field offset: 0x0
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x8
	private bool _skipAllChildren; //Field offset: 0x28
	private bool _skipchild; //Field offset: 0x29
	private bool _failed; //Field offset: 0x2A

	private RegexFCD(Span<Int32> intStack) { }

	private static int AnchorFromType(int type) { }

	public static int Anchors(RegexTree tree) { }

	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

	public void Dispose() { }

	private bool FCIsEmpty() { }

	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	private bool IntIsEmpty() { }

	private RegexFC PopFC() { }

	private int PopInt() { }

	public static RegexPrefix Prefix(RegexTree tree) { }

	private void PushFC(RegexFC fc) { }

	private void PushInt(int i) { }

	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	private void SkipChild() { }

	private RegexFC TopFC() { }

}

