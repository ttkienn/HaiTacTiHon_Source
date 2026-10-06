namespace Mono;

internal static class RuntimeMarshal
{

	internal static int AsciHexDigitValue(int c) { }

	internal static Byte[] DecodeBlobArray(IntPtr ptr) { }

	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

	internal static SafeStringMarshal MarshalString(string str) { }

	internal static string PtrToUtf8String(IntPtr ptr) { }

}

