namespace System.Threading;

public class AbandonedMutexException : SystemException
{
	private int _mutexIndex; //Field offset: 0x90
	private Mutex _mutex; //Field offset: 0x98

	public AbandonedMutexException() { }

	public AbandonedMutexException(int location, WaitHandle handle) { }

	protected AbandonedMutexException(SerializationInfo info, StreamingContext context) { }

	private void SetupException(int location, WaitHandle handle) { }

}

