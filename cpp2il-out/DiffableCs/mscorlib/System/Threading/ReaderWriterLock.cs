namespace System.Threading;

[ComVisible(True)]
public sealed class ReaderWriterLock : CriticalFinalizerObject
{
	private int seq_num; //Field offset: 0x10
	private int state; //Field offset: 0x14
	private int readers; //Field offset: 0x18
	private int writer_lock_owner; //Field offset: 0x1C
	private LockQueue writer_queue; //Field offset: 0x20
	private Hashtable reader_locks; //Field offset: 0x28

	public ReaderWriterLock() { }

	public void AcquireWriterLock(int millisecondsTimeout) { }

	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	protected virtual void Finalize() { }

	private bool HasWriterLock() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public void ReleaseWriterLock() { }

	private void ReleaseWriterLock(int releaseCount) { }

}

