namespace Mono.Btls;

internal class MonoBtlsPkcs12 : MonoBtlsObject
{
	public class BoringPkcs12Handle : MonoBtlsHandle
	{

		public BoringPkcs12Handle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}

	private MonoBtlsKey privateKey; //Field offset: 0x20

	public int Count
	{
		 get { } //Length: 145
	}

	internal BoringPkcs12Handle Handle
	{
		internal get { } //Length: 117
	}

	public bool HasPrivateKey
	{
		 get { } //Length: 154
	}

	internal MonoBtlsPkcs12() { }

	public int get_Count() { }

	internal BoringPkcs12Handle get_Handle() { }

	public bool get_HasPrivateKey() { }

	public MonoBtlsX509 GetCertificate(int index) { }

	public MonoBtlsKey GetPrivateKey() { }

	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	private static void mono_btls_pkcs12_free(IntPtr handle) { }

	private static IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	private static int mono_btls_pkcs12_get_count(IntPtr handle) { }

	private static IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	private static int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	private static int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	private static IntPtr mono_btls_pkcs12_new() { }

}

