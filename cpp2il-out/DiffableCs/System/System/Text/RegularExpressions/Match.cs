namespace System.Text.RegularExpressions;

public class Match : Group
{
	[CompilerGenerated]
	private static readonly Match <Empty>k__BackingField; //Field offset: 0x0
	internal GroupCollection _groupcoll; //Field offset: 0x40
	internal Regex _regex; //Field offset: 0x48
	internal int _textbeg; //Field offset: 0x50
	internal int _textpos; //Field offset: 0x54
	internal int _textend; //Field offset: 0x58
	internal int _textstart; //Field offset: 0x5C
	internal Int32[][] _matches; //Field offset: 0x60
	internal Int32[] _matchcount; //Field offset: 0x68
	internal bool _balancing; //Field offset: 0x70

	public static Match Empty
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	public override GroupCollection Groups
	{
		 get { } //Length: 140
	}

	private static Match() { }

	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	internal Match() { }

	internal override void AddMatch(int cap, int start, int len) { }

	internal override void BalanceMatch(int cap) { }

	[CompilerGenerated]
	public static Match get_Empty() { }

	public override GroupCollection get_Groups() { }

	internal override bool IsMatched(int cap) { }

	internal override int MatchIndex(int cap) { }

	internal override int MatchLength(int cap) { }

	public Match NextMatch() { }

	internal override void RemoveMatch(int cap) { }

	internal override void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	internal override void Tidy(int textpos) { }

}

