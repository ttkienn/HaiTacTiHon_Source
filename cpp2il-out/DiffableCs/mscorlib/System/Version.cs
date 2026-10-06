namespace System;

public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable
{
	private readonly int _Major; //Field offset: 0x10
	private readonly int _Minor; //Field offset: 0x14
	private readonly int _Build; //Field offset: 0x18
	private readonly int _Revision; //Field offset: 0x1C

	public int Build
	{
		 get { } //Length: 4
	}

	private int DefaultFormatFieldCount
	{
		private get { } //Length: 25
	}

	public int Major
	{
		 get { } //Length: 191
	}

	public int Minor
	{
		 get { } //Length: 4
	}

	public int Revision
	{
		 get { } //Length: 4
	}

	public Version(int major, int minor, int build, int revision) { }

	public Version(int major, int minor, int build) { }

	public Version(int major, int minor) { }

	public Version(string version) { }

	public Version() { }

	private Version(Version version) { }

	public override object Clone() { }

	public override int CompareTo(object version) { }

	public override int CompareTo(Version value) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Version obj) { }

	public int get_Build() { }

	private int get_DefaultFormatFieldCount() { }

	public int get_Major() { }

	public int get_Minor() { }

	public int get_Revision() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Version v1, Version v2) { }

	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	public static bool op_Inequality(Version v1, Version v2) { }

	public static bool op_LessThan(Version v1, Version v2) { }

	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	public static Version Parse(string input) { }

	private static Version ParseVersion(ReadOnlySpan<Char> input, bool throwOnFailure) { }

	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	private StringBuilder ToCachedStringBuilder(int fieldCount) { }

	public string ToString(int fieldCount) { }

	public virtual string ToString() { }

	public bool TryFormat(Span<Char> destination, out int charsWritten) { }

	public bool TryFormat(Span<Char> destination, int fieldCount, out int charsWritten) { }

	public static bool TryParse(string input, out Version result) { }

	private static bool TryParseComponent(ReadOnlySpan<Char> component, string componentName, bool throwOnFailure, out int parsedComponent) { }

}

