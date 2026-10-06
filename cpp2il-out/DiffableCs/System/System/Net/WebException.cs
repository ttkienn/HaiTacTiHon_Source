namespace System.Net;

public class WebException : InvalidOperationException, ISerializable
{
	private WebExceptionStatus m_Status; //Field offset: 0x90
	private WebResponse m_Response; //Field offset: 0x98
	private WebExceptionInternalStatus m_InternalStatus; //Field offset: 0xA0

	public WebResponse Response
	{
		 get { } //Length: 8
	}

	public WebExceptionStatus Status
	{
		 get { } //Length: 7
	}

	public WebException() { }

	public WebException(string message) { }

	public WebException(string message, Exception innerException) { }

	public WebException(string message, WebExceptionStatus status) { }

	internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public WebResponse get_Response() { }

	public WebExceptionStatus get_Status() { }

	public virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

