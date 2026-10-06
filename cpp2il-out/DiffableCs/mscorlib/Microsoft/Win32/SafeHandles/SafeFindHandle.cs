namespace Microsoft.Win32.SafeHandles;

internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	internal SafeFindHandle() { }

	protected virtual bool ReleaseHandle() { }

}

