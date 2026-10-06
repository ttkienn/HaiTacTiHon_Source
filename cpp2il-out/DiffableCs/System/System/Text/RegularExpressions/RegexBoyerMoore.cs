namespace System.Text.RegularExpressions;

internal sealed class RegexBoyerMoore
{
	public readonly Int32[] Positive; //Field offset: 0x10
	public readonly Int32[] NegativeASCII; //Field offset: 0x18
	public readonly Int32[][] NegativeUnicode; //Field offset: 0x20
	public readonly string Pattern; //Field offset: 0x28
	public readonly int LowASCII; //Field offset: 0x30
	public readonly int HighASCII; //Field offset: 0x34
	public readonly bool RightToLeft; //Field offset: 0x38
	public readonly bool CaseInsensitive; //Field offset: 0x39
	private readonly CultureInfo _culture; //Field offset: 0x40

	public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	private bool MatchPattern(string text, int index) { }

	public int Scan(string text, int index, int beglimit, int endlimit) { }

}

