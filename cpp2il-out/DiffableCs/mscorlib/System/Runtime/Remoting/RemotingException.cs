namespace System.Runtime.Remoting;

[ComVisible(True)]
public class RemotingException : SystemException
{

	public RemotingException() { }

	public RemotingException(string message) { }

	protected RemotingException(SerializationInfo info, StreamingContext context) { }

	public RemotingException(string message, Exception InnerException) { }

}

