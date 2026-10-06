namespace System.Runtime;

public static class RuntimeImports
{

	internal static void _ecvt_s(Byte* buffer, int sizeInBytes, double value, int count, Int32* dec, Int32* sign) { }

	internal static void Memmove(Byte* dest, Byte* src, uint len) { }

	internal static void Memmove_wbarrier(Byte* dest, Byte* src, uint len, IntPtr type_handle) { }

	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	private static void ZeroMemory(Void* p, uint byteLength) { }

}

