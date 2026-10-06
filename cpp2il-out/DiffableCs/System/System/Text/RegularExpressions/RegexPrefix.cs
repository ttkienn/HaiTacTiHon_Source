namespace System.Text.RegularExpressions;

[IsReadOnly]
internal struct RegexPrefix
{
	[CompilerGenerated]
	private static readonly RegexPrefix <Empty>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <CaseInsensitive>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Prefix>k__BackingField; //Field offset: 0x8

	internal bool CaseInsensitive
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal static RegexPrefix Empty
	{
		[CompilerGenerated]
		internal get { } //Length: 90
	}

	internal string Prefix
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	private static RegexPrefix() { }

	internal RegexPrefix(string prefix, bool ci) { }

	[CompilerGenerated]
	internal bool get_CaseInsensitive() { }

	[CompilerGenerated]
	internal static RegexPrefix get_Empty() { }

	[CompilerGenerated]
	internal string get_Prefix() { }

}

