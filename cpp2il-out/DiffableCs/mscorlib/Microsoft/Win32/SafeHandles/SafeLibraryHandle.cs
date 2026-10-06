namespace Microsoft.Win32.SafeHandles;

internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	internal SafeLibraryHandle() { }

	protected virtual bool ReleaseHandle() { }

}

