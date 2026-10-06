namespace System.Net.Security;

public class SslStream : AuthenticatedStream
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public LocalCertificateSelectionCallback callback; //Field offset: 0x10
		public SslStream <>4__this; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, String[] ai) { }

	}

	private MobileTlsProvider provider; //Field offset: 0x38
	private MonoTlsSettings settings; //Field offset: 0x40
	private RemoteCertificateValidationCallback validationCallback; //Field offset: 0x48
	private LocalCertificateSelectionCallback selectionCallback; //Field offset: 0x50
	private MobileAuthenticatedStream impl; //Field offset: 0x58
	private bool explicitSettings; //Field offset: 0x60

	public virtual bool CanRead
	{
		 get { } //Length: 34
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanTimeout
	{
		 get { } //Length: 42
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 34
	}

	internal MobileAuthenticatedStream Impl
	{
		internal get { } //Length: 102
	}

	internal string InternalTargetHost
	{
		internal get { } //Length: 109
	}

	public virtual bool IsAuthenticated
	{
		 get { } //Length: 121
	}

	public virtual long Length
	{
		 get { } //Length: 121
	}

	public override X509Certificate LocalCertificate
	{
		 get { } //Length: 108
	}

	public virtual long Position
	{
		 get { } //Length: 121
		 set { } //Length: 95
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 121
		 set { } //Length: 121
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 121
		 set { } //Length: 121
	}

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	public override void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public override IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	private void CheckDisposed() { }

	protected virtual void Dispose(bool disposing) { }

	public override void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanTimeout() { }

	public virtual bool get_CanWrite() { }

	internal MobileAuthenticatedStream get_Impl() { }

	internal string get_InternalTargetHost() { }

	public virtual bool get_IsAuthenticated() { }

	public virtual long get_Length() { }

	public override X509Certificate get_LocalCertificate() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	private static MobileTlsProvider GetProvider() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void set_ReadTimeout(int value) { }

	public virtual void set_WriteTimeout(int value) { }

	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

}

