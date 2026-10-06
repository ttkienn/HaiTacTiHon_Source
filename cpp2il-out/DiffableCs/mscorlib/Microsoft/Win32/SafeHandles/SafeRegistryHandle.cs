namespace Microsoft.Win32.SafeHandles;

public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	internal SafeRegistryHandle() { }

	public SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	protected virtual bool ReleaseHandle() { }

}

