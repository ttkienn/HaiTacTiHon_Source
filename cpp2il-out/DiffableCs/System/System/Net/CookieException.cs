namespace System.Net;

public class CookieException : FormatException, ISerializable
{

	public CookieException() { }

	internal CookieException(string message) { }

	internal CookieException(string message, Exception inner) { }

	protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

