namespace System.Text.RegularExpressions;

internal sealed class ExclusiveReference
{
	private RegexRunner _ref; //Field offset: 0x10
	private RegexRunner _obj; //Field offset: 0x18
	private int _locked; //Field offset: 0x20

	public ExclusiveReference() { }

	public RegexRunner Get() { }

	public void Release(RegexRunner obj) { }

}

