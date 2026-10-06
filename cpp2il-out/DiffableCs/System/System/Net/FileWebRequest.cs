namespace System.Net;

public class FileWebRequest : WebRequest, ISerializable
{
	private static WaitCallback s_GetRequestStreamCallback; //Field offset: 0x0
	private static WaitCallback s_GetResponseCallback; //Field offset: 0x8
	private string m_connectionGroupName; //Field offset: 0x38
	private long m_contentLength; //Field offset: 0x40
	private ICredentials m_credentials; //Field offset: 0x48
	private FileAccess m_fileAccess; //Field offset: 0x50
	private WebHeaderCollection m_headers; //Field offset: 0x58
	private string m_method; //Field offset: 0x60
	private IWebProxy m_proxy; //Field offset: 0x68
	private ManualResetEvent m_readerEvent; //Field offset: 0x70
	private bool m_readPending; //Field offset: 0x78
	private WebResponse m_response; //Field offset: 0x80
	private Stream m_stream; //Field offset: 0x88
	private bool m_syncHint; //Field offset: 0x90
	private int m_timeout; //Field offset: 0x94
	private Uri m_uri; //Field offset: 0x98
	private bool m_writePending; //Field offset: 0xA0
	private bool m_writing; //Field offset: 0xA1
	private LazyAsyncResult m_WriteAResult; //Field offset: 0xA8
	private LazyAsyncResult m_ReadAResult; //Field offset: 0xB0
	private int m_Aborted; //Field offset: 0xB8

	internal bool Aborted
	{
		internal get { } //Length: 11
	}

	public virtual long ContentLength
	{
		 get { } //Length: 5
	}

	public virtual ICredentials Credentials
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 5
	}

	public virtual string Method
	{
		 get { } //Length: 5
		 set { } //Length: 205
	}

	public virtual IWebProxy Proxy
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public virtual Uri RequestUri
	{
		 get { } //Length: 8
	}

	public virtual int Timeout
	{
		 get { } //Length: 7
	}

	public virtual bool UseDefaultCredentials
	{
		 get { } //Length: 39
	}

	private static FileWebRequest() { }

	internal FileWebRequest(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public virtual void Abort() { }

	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	internal bool get_Aborted() { }

	public virtual long get_ContentLength() { }

	public virtual ICredentials get_Credentials() { }

	public virtual WebHeaderCollection get_Headers() { }

	public virtual string get_Method() { }

	public virtual IWebProxy get_Proxy() { }

	public virtual Uri get_RequestUri() { }

	public virtual int get_Timeout() { }

	public virtual bool get_UseDefaultCredentials() { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private static void GetRequestStreamCallback(object state) { }

	public virtual WebResponse GetResponse() { }

	private static void GetResponseCallback(object state) { }

	public virtual void set_Credentials(ICredentials value) { }

	public virtual void set_Method(string value) { }

	public virtual void set_Proxy(IWebProxy value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void UnblockReader() { }

}

