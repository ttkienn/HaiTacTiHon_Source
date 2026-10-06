namespace Mono.Btls;

internal class MonoBtlsX509StoreCtx : MonoBtlsObject
{
	public class BoringX509StoreCtxHandle : MonoBtlsHandle
	{
		private bool dontFree; //Field offset: 0x20

		internal BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true) { }

		protected virtual bool ReleaseHandle() { }

	}

	private Nullable<Int32> verifyResult; //Field offset: 0x20

	internal BoringX509StoreCtxHandle Handle
	{
		internal get { } //Length: 113
	}

	public int VerifyResult
	{
		 get { } //Length: 132
	}

	internal MonoBtlsX509StoreCtx() { }

	internal MonoBtlsX509StoreCtx(BoringX509StoreCtxHandle ptr, Nullable<Int32> verifyResult) { }

	internal MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx) { }

	public MonoBtlsX509StoreCtx Copy() { }

	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	internal BoringX509StoreCtxHandle get_Handle() { }

	public int get_VerifyResult() { }

	public MonoBtlsX509Chain GetChain() { }

	public MonoBtlsX509Error GetError() { }

	public MonoBtlsX509Chain GetUntrusted() { }

	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	private static void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	private static IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	private static MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string) { }

	private static IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	private static int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	private static IntPtr mono_btls_x509_store_ctx_new() { }

	private static int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	private static IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	private static int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	public int Verify() { }

}

