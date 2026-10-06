namespace Microsoft.Win32.SafeHandles;

internal static class SafeHandleCache
{
	private static T s_invalidHandle; //Field offset: 0x0

	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }

}

