namespace Mono.Btls;

internal class MonoBtlsSsl : MonoBtlsObject
{
	public class BoringSslHandle : MonoBtlsHandle
	{

		public BoringSslHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class PrintErrorsCallbackFunc : MulticastDelegate
	{

		public PrintErrorsCallbackFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr str, IntPtr len, IntPtr ctx) { }

	}

	private MonoBtlsBio bio; //Field offset: 0x20
	private PrintErrorsCallbackFunc printErrorsFunc; //Field offset: 0x28
	private IntPtr printErrorsFuncPtr; //Field offset: 0x30

	internal BoringSslHandle Handle
	{
		internal get { } //Length: 113
	}

	public MonoBtlsSsl(MonoBtlsSslCtx ctx) { }

	public MonoBtlsSslError Accept() { }

	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	protected virtual void Close() { }

	public MonoBtlsSslError Connect() { }

	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	internal BoringSslHandle get_Handle() { }

	public int GetCipher() { }

	private MonoBtlsSslError GetError(int ret_code) { }

	public string GetErrors() { }

	public MonoBtlsX509 GetPeerCertificate() { }

	public string GetServerName() { }

	public int GetVersion() { }

	public MonoBtlsSslError Handshake() { }

	private static int mono_btls_ssl_accept(IntPtr handle) { }

	private static int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	private static void mono_btls_ssl_close(IntPtr handle) { }

	private static int mono_btls_ssl_connect(IntPtr handle) { }

	private static void mono_btls_ssl_destroy(IntPtr handle) { }

	private static int mono_btls_ssl_get_cipher(IntPtr handle) { }

	private static int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	private static IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	private static IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	private static int mono_btls_ssl_get_version(IntPtr handle) { }

	private static int mono_btls_ssl_handshake(IntPtr handle) { }

	private static IntPtr mono_btls_ssl_new(IntPtr handle) { }

	private static void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	private static int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	private static int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	private static void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	private static void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	private static void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	private static int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	private static int mono_btls_ssl_shutdown(IntPtr handle) { }

	private static int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	private static int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	private static int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	public void PrintErrors() { }

	[MonoPInvokeCallback(typeof(PrintErrorsCallbackFunc))]
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	public MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	public bool RenegotiatePending() { }

	public void SetBio(MonoBtlsBio bio) { }

	public void SetCertificate(MonoBtlsX509 x509) { }

	public void SetPrivateKey(MonoBtlsKey key) { }

	public void SetQuietShutdown() { }

	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	public void SetServerName(string name) { }

	public void Shutdown() { }

	private Exception ThrowError(string callerName = null) { }

	public MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

}

