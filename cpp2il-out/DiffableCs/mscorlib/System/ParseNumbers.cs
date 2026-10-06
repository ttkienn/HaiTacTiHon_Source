namespace System;

internal static class ParseNumbers
{

	private static void EatWhiteSpace(ReadOnlySpan<Char> s, ref int i) { }

	private static int GrabInts(int radix, ReadOnlySpan<Char> s, ref int i, bool isUnsigned) { }

	private static long GrabLongs(int radix, ReadOnlySpan<Char> s, ref int i, bool isUnsigned) { }

	private static bool IsDigit(char c, int radix, out int result) { }

	public static string LongToString(long n, int radix, int width, char paddingChar, int flags) { }

	public static int StringToInt(ReadOnlySpan<Char> s, int radix, int flags) { }

	public static int StringToInt(ReadOnlySpan<Char> s, int radix, int flags, ref int currPos) { }

	public static long StringToLong(ReadOnlySpan<Char> s, int radix, int flags) { }

	public static long StringToLong(ReadOnlySpan<Char> s, int radix, int flags, ref int currPos) { }

	private static void ThrowOverflowInt32Exception() { }

	private static void ThrowOverflowInt64Exception() { }

	private static void ThrowOverflowUInt32Exception() { }

	private static void ThrowOverflowUInt64Exception() { }

}

