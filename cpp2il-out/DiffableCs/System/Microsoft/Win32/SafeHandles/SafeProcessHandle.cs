namespace Microsoft.Win32.SafeHandles;

public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeProcessHandle InvalidHandle; //Field offset: 0x0

	private static SafeProcessHandle() { }

	internal SafeProcessHandle(IntPtr handle) { }

	public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle) { }

	protected virtual bool ReleaseHandle() { }

}

