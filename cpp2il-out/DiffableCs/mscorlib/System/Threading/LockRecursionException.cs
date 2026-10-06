namespace System.Threading;

public class LockRecursionException : Exception
{

	public LockRecursionException() { }

	public LockRecursionException(string message) { }

	protected LockRecursionException(SerializationInfo info, StreamingContext context) { }

}

