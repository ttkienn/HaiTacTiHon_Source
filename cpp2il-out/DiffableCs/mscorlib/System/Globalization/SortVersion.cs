namespace System.Globalization;

public sealed class SortVersion : IEquatable<SortVersion>
{
	private int m_NlsVersion; //Field offset: 0x10
	private Guid m_SortId; //Field offset: 0x14

	public virtual bool Equals(object obj) { }

	public override bool Equals(SortVersion other) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(SortVersion left, SortVersion right) { }

	public static bool op_Inequality(SortVersion left, SortVersion right) { }

}

