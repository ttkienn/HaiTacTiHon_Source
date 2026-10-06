namespace System.Runtime.Serialization;

public class SerializationException : SystemException
{
	private static string s_nullMessage; //Field offset: 0x0

	private static SerializationException() { }

	public SerializationException() { }

	public SerializationException(string message) { }

	public SerializationException(string message, Exception innerException) { }

	protected SerializationException(SerializationInfo info, StreamingContext context) { }

}

