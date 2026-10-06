namespace System.Text.RegularExpressions;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct RegexWriter
{
	private ValueListBuilder<Int32> _emitted; //Field offset: 0x0
	private ValueListBuilder<Int32> _intStack; //Field offset: 0x20
	private readonly Dictionary<String, Int32> _stringHash; //Field offset: 0x40
	private readonly List<String> _stringTable; //Field offset: 0x48
	private Hashtable _caps; //Field offset: 0x50
	private int _trackCount; //Field offset: 0x58

	private RegexWriter(Span<Int32> emittedSpan, Span<Int32> intStackSpan) { }

	public void Dispose() { }

	private void Emit(int op) { }

	private void Emit(int op, int opd1) { }

	private void Emit(int op, int opd1, int opd2) { }

	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }

	private int MapCapnum(int capnum) { }

	private void PatchJump(int offset, int jumpDest) { }

	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	private int StringCode(string str) { }

	public static RegexCode Write(RegexTree tree) { }

}

