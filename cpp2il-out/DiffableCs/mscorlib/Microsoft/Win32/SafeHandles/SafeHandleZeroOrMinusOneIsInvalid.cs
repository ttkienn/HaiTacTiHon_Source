namespace Microsoft.Win32.SafeHandles;

public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
{

	public virtual bool IsInvalid
	{
		 get { } //Length: 85
	}

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle) { }

	public virtual bool get_IsInvalid() { }

}

