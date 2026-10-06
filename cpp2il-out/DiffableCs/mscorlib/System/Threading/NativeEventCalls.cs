namespace System.Threading;

internal static class NativeEventCalls
{

	public static void CloseEvent_internal(IntPtr handle) { }

	private static IntPtr CreateEvent_icall(bool manual, bool initial, Char* name, int name_length, out int errorCode) { }

	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	public static bool ResetEvent(SafeWaitHandle handle) { }

	private static bool ResetEvent_internal(IntPtr handle) { }

	public static bool SetEvent(SafeWaitHandle handle) { }

	private static bool SetEvent_internal(IntPtr handle) { }

}

