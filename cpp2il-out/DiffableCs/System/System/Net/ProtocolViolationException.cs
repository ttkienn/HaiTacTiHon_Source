namespace System.Net;

public class ProtocolViolationException : InvalidOperationException, ISerializable
{

	public ProtocolViolationException() { }

	public ProtocolViolationException(string message) { }

	protected ProtocolViolationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

