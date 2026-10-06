namespace System.Runtime.CompilerServices;

internal static class Unsafe
{

	public static T Add(ref T source, int elementOffset) { }

	public static T Add(ref T source, IntPtr elementOffset) { }

	public static Void* Add(Void* source, int elementOffset) { }

	internal static T AddByteOffset(ref T source, ulong byteOffset) { }

	public static T AddByteOffset(ref T source, IntPtr byteOffset) { }

	public static bool AreSame(ref T left, ref T right) { }

	public static T As(object o) { }

	public static TTo As(ref TFrom source) { }

	public static Void* AsPointer(ref T value) { }

	public static T AsRef(in T source) { }

	public static T AsRef(Void* source) { }

	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	public static bool IsAddressLessThan(ref T left, ref T right) { }

	public static T Read(Void* source) { }

	public static T ReadUnaligned(ref byte source) { }

	public static int SizeOf() { }

	public static void WriteUnaligned(ref byte destination, T value) { }

}

