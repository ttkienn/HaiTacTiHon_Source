namespace System;

[Extension]
public static class MemoryExtensions
{

	[Extension]
	public static Span<T> AsSpan(T[] array, int start, int length) { }

	[Extension]
	public static Span<T> AsSpan(T[] array, int start) { }

	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text) { }

	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text, int start) { }

	[Extension]
	public static ReadOnlySpan<Char> AsSpan(string text, int start, int length) { }

	[Extension]
	internal static bool Contains(ReadOnlySpan<Char> source, char value) { }

	[Extension]
	public static void CopyTo(T[] source, Span<T> destination) { }

	[Extension]
	public static bool EndsWith(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, StringComparison comparisonType) { }

	[Extension]
	public static bool EndsWith(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }

	[Extension]
	internal static bool EqualsOrdinal(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[Extension]
	internal static bool EqualsOrdinalIgnoreCase(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	[Extension]
	public static int IndexOf(ReadOnlySpan<T> span, T value) { }

	[Extension]
	public static int IndexOfAny(ReadOnlySpan<T> span, ReadOnlySpan<T> values) { }

	private static bool IsTypeComparableAsBytes(out ulong size) { }

	[Extension]
	public static bool SequenceEqual(ReadOnlySpan<T> span, ReadOnlySpan<T> other) { }

	[Extension]
	public static bool StartsWith(ReadOnlySpan<T> span, ReadOnlySpan<T> value) { }

	[Extension]
	public static int ToUpperInvariant(ReadOnlySpan<Char> source, Span<Char> destination) { }

	[Extension]
	public static ReadOnlySpan<Char> Trim(ReadOnlySpan<Char> span) { }

	[Extension]
	public static ReadOnlySpan<Char> TrimEnd(ReadOnlySpan<Char> span) { }

	[Extension]
	public static ReadOnlySpan<Char> TrimStart(ReadOnlySpan<Char> span) { }

}

