namespace Mono.Btls;

internal class MonoBtlsX509Lookup : MonoBtlsObject
{
	public class BoringX509LookupHandle : MonoBtlsHandle
	{

		public BoringX509LookupHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}

	private MonoBtlsX509Store store; //Field offset: 0x20
	private MonoBtlsX509LookupType type; //Field offset: 0x28
	private List<MonoBtlsX509LookupMono> monoLookups; //Field offset: 0x30

	internal BoringX509LookupHandle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	internal void AddCertificate(MonoBtlsX509 certificate) { }

	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	protected virtual void Close() { }

	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	internal BoringX509LookupHandle get_Handle() { }

	internal IntPtr GetNativeLookup() { }

	private static int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	private static int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	private static void mono_btls_x509_lookup_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	private static IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

}

