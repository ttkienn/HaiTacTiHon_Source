namespace Mono.Unity;

internal class UnityTlsContext : MobileTlsContext
{
	private unitytls_tlsctx* tlsContext; //Field offset: 0x58
	private unitytls_x509list* requestedClientCertChain; //Field offset: 0x60
	private unitytls_key* requestedClientKey; //Field offset: 0x68
	private unitytls_tlsctx_read_callback readCallback; //Field offset: 0x70
	private unitytls_tlsctx_write_callback writeCallback; //Field offset: 0x78
	private unitytls_tlsctx_certificate_callback certificateCallback; //Field offset: 0x80
	private unitytls_tlsctx_x509verify_callback verifyCallback; //Field offset: 0x88
	private X509Certificate localClientCertificate; //Field offset: 0x90
	private X509Certificate2 remoteCertificate; //Field offset: 0x98
	private MonoTlsConnectionInfo connectioninfo; //Field offset: 0xA0
	private bool isAuthenticated; //Field offset: 0xA8
	private bool hasContext; //Field offset: 0xA9
	private bool closedGraceful; //Field offset: 0xAA
	private Byte[] writeBuffer; //Field offset: 0xB0
	private Byte[] readBuffer; //Field offset: 0xB8
	private GCHandle handle; //Field offset: 0xC0
	private Exception lastException; //Field offset: 0xC8

	public virtual bool IsAuthenticated
	{
		 get { } //Length: 8
	}

	internal virtual X509Certificate LocalClientCertificate
	{
		internal get { } //Length: 8
	}

	public virtual X509Certificate2 RemoteCertificate
	{
		 get { } //Length: 8
	}

	public UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[MonoPInvokeCallback(typeof(unitytls_tlsctx_certificate_callback))]
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	protected virtual void Dispose(bool disposing) { }

	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, out unitytls_x509list* nativeCertChain, out unitytls_key* nativeKey) { }

	public virtual void FinishHandshake() { }

	public virtual void Flush() { }

	public virtual bool get_IsAuthenticated() { }

	internal virtual X509Certificate get_LocalClientCertificate() { }

	public virtual X509Certificate2 get_RemoteCertificate() { }

	public virtual bool PendingRenegotiation() { }

	public virtual bool ProcessHandshake() { }

	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	[MonoPInvokeCallback(typeof(unitytls_tlsctx_read_callback))]
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	public virtual void Renegotiate() { }

	public virtual void Shutdown() { }

	public virtual void StartHandshake() { }

	[MonoPInvokeCallback(typeof(unitytls_tlsctx_x509verify_callback))]
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

	[MonoPInvokeCallback(typeof(unitytls_tlsctx_write_callback))]
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

