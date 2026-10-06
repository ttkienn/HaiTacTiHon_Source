namespace System.Text.RegularExpressions;

internal sealed class RegexFC
{
	private RegexCharClass _cc; //Field offset: 0x10
	public bool _nullable; //Field offset: 0x18
	[CompilerGenerated]
	private bool <CaseInsensitive>k__BackingField; //Field offset: 0x19

	public private bool CaseInsensitive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public RegexFC(bool nullable) { }

	public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive) { }

	public RegexFC(string charClass, bool nullable, bool caseInsensitive) { }

	public bool AddFC(RegexFC fc, bool concatenate) { }

	[CompilerGenerated]
	public bool get_CaseInsensitive() { }

	public string GetFirstChars(CultureInfo culture) { }

	[CompilerGenerated]
	private void set_CaseInsensitive(bool value) { }

}

