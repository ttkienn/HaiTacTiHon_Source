namespace UnityEngine;

internal static class ManagedStreamHelpers
{

	[RequiredByNativeCode]
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	internal static void ValidateLoadFromStream(Stream stream) { }

}

