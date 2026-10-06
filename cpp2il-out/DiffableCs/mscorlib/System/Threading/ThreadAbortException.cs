namespace System.Threading;

[ComVisible(True)]
public sealed class ThreadAbortException : SystemException
{

	private ThreadAbortException() { }

	internal ThreadAbortException(SerializationInfo info, StreamingContext context) { }

}

