namespace System.Net;

public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	private bool m_IsFromCache; //Field offset: 0x18

	public override WebHeaderCollection Headers
	{
		 get { } //Length: 39
	}

	public override bool IsFromCache
	{
		 get { } //Length: 5
	}

	public override Uri ResponseUri
	{
		 get { } //Length: 125
	}

	protected WebResponse() { }

	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void Close() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override WebHeaderCollection get_Headers() { }

	public override bool get_IsFromCache() { }

	public override Uri get_ResponseUri() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override Stream GetResponseStream() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

