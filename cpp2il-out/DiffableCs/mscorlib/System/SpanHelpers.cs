namespace System;

[Extension]
internal static class SpanHelpers
{

	public static void ClearWithoutReferences(ref byte b, ulong byteLength) { }

	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength) { }

	public static bool EndsWithCultureHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value, CompareInfo compareInfo) { }

	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<Char> span, ReadOnlySpan<Char> value) { }

	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	public static int IndexOf(ref char searchSpace, char value, int length) { }

	public static int IndexOf(ref T searchSpace, T value, int length) { }

	public static int IndexOfAny(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) { }

	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength) { }

	public static int LastIndexOf(ref char searchSpace, char value, int length) { }

	private static int LocateFirstFoundChar(ulong match) { }

	private static int LocateFirstFoundChar(Vector<UInt16> match) { }

	private static int LocateLastFoundChar(ulong match) { }

	private static int LocateLastFoundChar(Vector<UInt16> match) { }

	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength) { }

	public static bool SequenceEqual(ref T first, ref T second, int length) { }

	public static bool SequenceEqual(ref byte first, ref byte second, ulong length) { }

}

