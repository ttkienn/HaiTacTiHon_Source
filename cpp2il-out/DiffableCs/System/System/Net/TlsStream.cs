namespace System.Net;

internal class TlsStream : NetworkStream
{
	private SslStream _sslStream; //Field offset: 0x48
	private string _host; //Field offset: 0x50
	private X509CertificateCollection _clientCertificates; //Field offset: 0x58

	public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	public void AuthenticateAsClient() { }

	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public virtual void Close() { }

	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult result) { }

	public virtual int Read(Byte[] buffer, int offset, int size) { }

	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

