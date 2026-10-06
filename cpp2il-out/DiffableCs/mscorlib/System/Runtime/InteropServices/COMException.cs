namespace System.Runtime.InteropServices;

public class COMException : ExternalException
{

	public COMException() { }

	protected COMException(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

