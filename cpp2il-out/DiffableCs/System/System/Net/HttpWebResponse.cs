namespace System.Net;

public class HttpWebResponse : WebResponse, ISerializable, IDisposable
{
	private Uri uri; //Field offset: 0x20
	private WebHeaderCollection webHeaders; //Field offset: 0x28
	private CookieCollection cookieCollection; //Field offset: 0x30
	private string method; //Field offset: 0x38
	private Version version; //Field offset: 0x40
	private HttpStatusCode statusCode; //Field offset: 0x48
	private string statusDescription; //Field offset: 0x50
	private long contentLength; //Field offset: 0x58
	private string contentType; //Field offset: 0x60
	private CookieContainer cookie_container; //Field offset: 0x68
	private bool disposed; //Field offset: 0x70
	private Stream stream; //Field offset: 0x78

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 5
	}

	public virtual Uri ResponseUri
	{
		 get { } //Length: 26
	}

	public override HttpStatusCode StatusCode
	{
		 get { } //Length: 4
	}

	public override string StatusDescription
	{
		 get { } //Length: 26
	}

	public HttpWebResponse() { }

	internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Obsolete("Serialization is obsoleted for this type", False)]
	protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void CheckDisposed() { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	private void FillCookies() { }

	public virtual WebHeaderCollection get_Headers() { }

	public virtual Uri get_ResponseUri() { }

	public override HttpStatusCode get_StatusCode() { }

	public override string get_StatusDescription() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual Stream GetResponseStream() { }

	private override void System.IDisposable.Dispose() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

