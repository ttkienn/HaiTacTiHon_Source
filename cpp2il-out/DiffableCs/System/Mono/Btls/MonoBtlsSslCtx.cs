namespace Mono.Btls;

internal class MonoBtlsSslCtx : MonoBtlsObject
{
	public class BoringSslCtxHandle : MonoBtlsHandle
	{

		public BoringSslCtxHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeSelectFunc : MulticastDelegate
	{

		public NativeSelectFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeServerNameFunc : MulticastDelegate
	{

		public NativeServerNameFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr instance) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeVerifyFunc : MulticastDelegate
	{

		public NativeVerifyFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

	}

	private NativeVerifyFunc verifyFunc; //Field offset: 0x20
	private NativeSelectFunc selectFunc; //Field offset: 0x28
	private NativeServerNameFunc serverNameFunc; //Field offset: 0x30
	private IntPtr verifyFuncPtr; //Field offset: 0x38
	private IntPtr selectFuncPtr; //Field offset: 0x40
	private IntPtr serverNameFuncPtr; //Field offset: 0x48
	private MonoBtlsVerifyCallback verifyCallback; //Field offset: 0x50
	private MonoBtlsSelectCallback selectCallback; //Field offset: 0x58
	private MonoBtlsServerNameCallback serverNameCallback; //Field offset: 0x60
	private MonoBtlsX509Store store; //Field offset: 0x68
	private GCHandle instance; //Field offset: 0x70
	private IntPtr instancePtr; //Field offset: 0x78

	public MonoBtlsX509Store CertificateStore
	{
		 get { } //Length: 5
	}

	internal BoringSslCtxHandle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsSslCtx(BoringSslCtxHandle handle) { }

	public MonoBtlsSslCtx() { }

	protected virtual void Close() { }

	private static String[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	public MonoBtlsX509Store get_CertificateStore() { }

	internal BoringSslCtxHandle get_Handle() { }

	private static int mono_btls_ssl_ctx_free(IntPtr handle) { }

	private static void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	private static IntPtr mono_btls_ssl_ctx_new() { }

	private static void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	private static void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	private static int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	private static int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	private static void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	private static void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	private static void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	private static int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	[MonoPInvokeCallback(typeof(NativeSelectFunc))]
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	[MonoPInvokeCallback(typeof(NativeServerNameFunc))]
	private static int NativeServerNameCallback(IntPtr instance) { }

	[MonoPInvokeCallback(typeof(NativeVerifyFunc))]
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	public void SetClientCertificateIssuers(String[] acceptableIssuers) { }

	public void SetMaxVersion(int version) { }

	public void SetMinVersion(int version) { }

	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

}

