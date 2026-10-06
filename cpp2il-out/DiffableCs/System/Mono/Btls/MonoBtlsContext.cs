namespace Mono.Btls;

internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
{
	private X509Certificate2 remoteCertificate; //Field offset: 0x58
	private X509Certificate clientCertificate; //Field offset: 0x60
	private X509CertificateImplBtls nativeServerCertificate; //Field offset: 0x68
	private X509CertificateImplBtls nativeClientCertificate; //Field offset: 0x70
	private MonoBtlsSslCtx ctx; //Field offset: 0x78
	private MonoBtlsSsl ssl; //Field offset: 0x80
	private MonoBtlsBio bio; //Field offset: 0x88
	private MonoBtlsBio errbio; //Field offset: 0x90
	private MonoTlsConnectionInfo connectionInfo; //Field offset: 0x98
	private bool certificateValidated; //Field offset: 0xA0
	private bool isAuthenticated; //Field offset: 0xA1
	private bool connected; //Field offset: 0xA2

	public virtual bool IsAuthenticated
	{
		 get { } //Length: 8
	}

	internal virtual X509Certificate LocalClientCertificate
	{
		internal get { } //Length: 5
	}

	public virtual X509Certificate2 RemoteCertificate
	{
		 get { } //Length: 5
	}

	public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	protected virtual void Dispose(bool disposing) { }

	private void Dispose(ref T disposable) { }

	private MonoBtlsSslError DoProcessHandshake() { }

	public virtual void FinishHandshake() { }

	public virtual void Flush() { }

	public virtual bool get_IsAuthenticated() { }

	internal virtual X509Certificate get_LocalClientCertificate() { }

	public virtual X509Certificate2 get_RemoteCertificate() { }

	private static Exception GetException(MonoBtlsSslError status) { }

	private void GetPeerCertificate() { }

	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	private void InitializeConnection() { }

	private void InitializeSession() { }

	private override void Mono.Btls.IMonoBtlsBioMono.Close() { }

	private override void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	private override int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	private override bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	public virtual bool PendingRenegotiation() { }

	public virtual bool ProcessHandshake() { }

	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int size) { }

	public virtual void Renegotiate() { }

	private int SelectCallback(String[] acceptableIssuers) { }

	private int ServerNameCallback() { }

	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	public virtual void Shutdown() { }

	public virtual void StartHandshake() { }

	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int size) { }

}

