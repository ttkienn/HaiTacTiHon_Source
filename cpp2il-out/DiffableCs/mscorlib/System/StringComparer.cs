namespace System;

public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	private static readonly CultureAwareComparer s_invariantCulture; //Field offset: 0x0
	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; //Field offset: 0x8
	private static readonly OrdinalCaseSensitiveComparer s_ordinal; //Field offset: 0x10
	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; //Field offset: 0x18

	public static StringComparer InvariantCultureIgnoreCase
	{
		 get { } //Length: 79
	}

	public static StringComparer Ordinal
	{
		 get { } //Length: 79
	}

	public static StringComparer OrdinalIgnoreCase
	{
		 get { } //Length: 79
	}

	private static StringComparer() { }

	protected StringComparer() { }

	public override int Compare(object x, object y) { }

	public abstract int Compare(string x, string y) { }

	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	public override bool Equals(object x, object y) { }

	public abstract bool Equals(string x, string y) { }

	public static StringComparer get_InvariantCultureIgnoreCase() { }

	public static StringComparer get_Ordinal() { }

	public static StringComparer get_OrdinalIgnoreCase() { }

	public override int GetHashCode(object obj) { }

	public abstract int GetHashCode(string obj) { }

}

