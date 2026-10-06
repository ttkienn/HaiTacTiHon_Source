namespace Mono.Btls;

internal class MonoBtlsX509Chain : MonoBtlsObject
{
	public class BoringX509ChainHandle : MonoBtlsHandle
	{

		public BoringX509ChainHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}


	public int Count
	{
		 get { } //Length: 145
	}

	internal BoringX509ChainHandle Handle
	{
		internal get { } //Length: 113
	}

	public MonoBtlsX509Chain() { }

	internal MonoBtlsX509Chain(BoringX509ChainHandle handle) { }

	public void AddCertificate(MonoBtlsX509 x509) { }

	internal MonoBtlsX509Chain Copy() { }

	public int get_Count() { }

	internal BoringX509ChainHandle get_Handle() { }

	public MonoBtlsX509 GetCertificate(int index) { }

	private static int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	private static void mono_btls_x509_chain_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	private static int mono_btls_x509_chain_get_count(IntPtr handle) { }

	private static IntPtr mono_btls_x509_chain_new() { }

	private static IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

}

