namespace Microsoft.Win32.SafeHandles;

public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	private SafeWaitHandle() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle) { }

	protected virtual bool ReleaseHandle() { }

}

