namespace Microsoft.Win32.SafeHandles;

public abstract class SafeHandleMinusOneIsInvalid : SafeHandle
{

	public virtual bool IsInvalid
	{
		 get { } //Length: 59
	}

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected SafeHandleMinusOneIsInvalid(bool ownsHandle) { }

	public virtual bool get_IsInvalid() { }

}

