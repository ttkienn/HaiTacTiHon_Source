namespace Mono.Btls;

internal class MonoBtlsX509Store : MonoBtlsObject
{
	public class BoringX509StoreHandle : MonoBtlsHandle
	{

		public BoringX509StoreHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}

	private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash; //Field offset: 0x20

	internal BoringX509StoreHandle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsX509Store() { }

	internal MonoBtlsX509Store(BoringSslCtxHandle ctx) { }

	public void AddCertificate(MonoBtlsX509 x509) { }

	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	protected virtual void Close() { }

	private static BoringX509StoreHandle Create_internal() { }

	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	internal BoringX509StoreHandle get_Handle() { }

	private static int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	private static void mono_btls_x509_store_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	private static IntPtr mono_btls_x509_store_new() { }

}

