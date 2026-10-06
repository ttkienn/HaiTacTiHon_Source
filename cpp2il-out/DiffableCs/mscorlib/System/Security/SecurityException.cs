namespace System.Security;

[ComVisible(True)]
public class SecurityException : SystemException
{
	private string permissionState; //Field offset: 0x90

	public SecurityException() { }

	public SecurityException(string message) { }

	protected SecurityException(SerializationInfo info, StreamingContext context) { }

	public SecurityException(string message, Exception inner) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

