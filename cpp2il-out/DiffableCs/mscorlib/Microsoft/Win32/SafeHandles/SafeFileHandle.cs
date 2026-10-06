namespace Microsoft.Win32.SafeHandles;

public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	protected virtual bool ReleaseHandle() { }

}

