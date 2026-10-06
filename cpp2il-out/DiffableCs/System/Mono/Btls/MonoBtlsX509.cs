namespace Mono.Btls;

internal class MonoBtlsX509 : MonoBtlsObject
{
	public class BoringX509Handle : MonoBtlsHandle
	{

		public BoringX509Handle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

		public IntPtr StealHandle() { }

	}


	internal BoringX509Handle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsX509(BoringX509Handle handle) { }

	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	internal MonoBtlsX509 Copy() { }

	internal BoringX509Handle get_Handle() { }

	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	public MonoBtlsX509Name GetSubjectName() { }

	public long GetSubjectNameHash() { }

	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	private static int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	private static int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	private static void mono_btls_x509_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	private static int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	private static IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	private static IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

}

