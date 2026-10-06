namespace System.Threading;

internal class LockQueue
{
	private ReaderWriterLock rwlock; //Field offset: 0x10
	private int lockCount; //Field offset: 0x18

	public bool IsEmpty
	{
		 get { } //Length: 145
	}

	public LockQueue(ReaderWriterLock rwlock) { }

	public bool get_IsEmpty() { }

	public void Pulse() { }

	public bool Wait(int timeout) { }

}

