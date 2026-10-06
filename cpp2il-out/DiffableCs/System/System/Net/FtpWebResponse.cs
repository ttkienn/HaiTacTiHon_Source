namespace System.Net;

public class FtpWebResponse : WebResponse, IDisposable
{
	public sealed class EmptyStream : MemoryStream
	{

		internal EmptyStream() { }

	}

	internal Stream _responseStream; //Field offset: 0x20
	private long _contentLength; //Field offset: 0x28
	private Uri _responseUri; //Field offset: 0x30
	private FtpStatusCode _statusCode; //Field offset: 0x38
	private string _statusLine; //Field offset: 0x40
	private WebHeaderCollection _ftpRequestHeaders; //Field offset: 0x48
	private DateTime _lastModified; //Field offset: 0x50
	private string _bannerMessage; //Field offset: 0x58
	private string _welcomeMessage; //Field offset: 0x60
	private string _exitMessage; //Field offset: 0x68

	public virtual WebHeaderCollection Headers
	{
		 get { } //Length: 238
	}

	public virtual Uri ResponseUri
	{
		 get { } //Length: 5
	}

	public FtpStatusCode StatusCode
	{
		 get { } //Length: 4
	}

	internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	public virtual void Close() { }

	public virtual WebHeaderCollection get_Headers() { }

	public virtual Uri get_ResponseUri() { }

	public FtpStatusCode get_StatusCode() { }

	public virtual Stream GetResponseStream() { }

	internal void SetResponseStream(Stream stream) { }

	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

}

