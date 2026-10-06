namespace System.Globalization;

public sealed class IdnMapping
{
	private bool allow_unassigned; //Field offset: 0x10
	private bool use_std3; //Field offset: 0x11
	private Punycode puny; //Field offset: 0x18

	public IdnMapping() { }

	private string Convert(string input, int index, int count, bool toAscii) { }

	public virtual bool Equals(object obj) { }

	public string GetAscii(string unicode) { }

	public string GetAscii(string unicode, int index, int count) { }

	public virtual int GetHashCode() { }

	public string GetUnicode(string ascii) { }

	public string GetUnicode(string ascii, int index, int count) { }

	private string NamePrep(string s, int offset) { }

	private string ToAscii(string s, int offset) { }

	private string ToUnicode(string s, int offset) { }

	private void VerifyLength(string s, int offset) { }

	private void VerifyProhibitedCharacters(string s, int offset) { }

	private void VerifyStd3AsciiRules(string s, int offset) { }

}

