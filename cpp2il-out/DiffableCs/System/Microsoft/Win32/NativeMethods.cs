namespace Microsoft.Win32;

internal static class NativeMethods
{

	public static bool CloseProcess(IntPtr handle) { }

	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	public static IntPtr GetCurrentProcess() { }

	public static int GetCurrentProcessId() { }

	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

}

