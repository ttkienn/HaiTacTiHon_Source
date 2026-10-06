namespace System.Runtime.InteropServices;

public class ExternalException : SystemException
{

	public ExternalException() { }

	public ExternalException(string message) { }

	public ExternalException(string message, int errorCode) { }

	protected ExternalException(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

