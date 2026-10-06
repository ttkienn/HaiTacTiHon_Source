namespace System.Runtime.InteropServices;

public abstract class SafeHandle : CriticalFinalizerObject, IDisposable
{
	private const int RefCount_Mask = 2147483644; //Field offset: 0x0
	private const int RefCount_One = 4; //Field offset: 0x0
	protected IntPtr handle; //Field offset: 0x10
	private int _state; //Field offset: 0x18
	private bool _ownsHandle; //Field offset: 0x1C
	private bool _fullyInitialized; //Field offset: 0x1D

	public bool IsClosed
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 7
	}

	public abstract bool IsInvalid
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 0
	}

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	protected SafeHandle(IntPtr invalidHandleValue, bool ownsHandle) { }

	protected SafeHandle() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void Close() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void DangerousRelease() { }

	private void DangerousReleaseInternal(bool dispose) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected override void Dispose(bool disposing) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public override void Dispose() { }

	protected virtual void Finalize() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public bool get_IsClosed() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public abstract bool get_IsInvalid() { }

	private void InternalDispose() { }

	private void InternalFinalize() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected abstract bool ReleaseHandle() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void SetHandleAsInvalid() { }

}

