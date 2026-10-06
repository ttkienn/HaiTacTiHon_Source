namespace System.Net;

public class FileWebResponse : WebResponse, ISerializable, ICloseEx
{
	private bool m_closed; //Field offset: 0x20
	private long m_contentLength; //Field offset: 0x28
	private FileAccess m_fileAccess; //Field offset: 0x30
	private WebHeaderCollection m_headers; //Field offset: 0x38
	private Stream m_stream; //Field offset: 0x40
	private Uri m_uri; //Field offset: 0x48

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 26
	}

	public virtual Uri ResponseUri
	{
		 get { } //Length: 26
	}

	internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void CheckDisposed() { }

	public virtual void Close() { }

	public virtual WebHeaderCollection get_Headers() { }

	public virtual Uri get_ResponseUri() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual Stream GetResponseStream() { }

	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

