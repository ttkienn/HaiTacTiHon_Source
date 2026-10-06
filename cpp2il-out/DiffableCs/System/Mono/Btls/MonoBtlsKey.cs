namespace Mono.Btls;

internal class MonoBtlsKey : MonoBtlsObject
{
	public class BoringKeyHandle : MonoBtlsHandle
	{

		internal BoringKeyHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}


	internal BoringKeyHandle Handle
	{
		internal get { } //Length: 117
	}

	internal MonoBtlsKey(BoringKeyHandle handle) { }

	public MonoBtlsKey Copy() { }

	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

	internal BoringKeyHandle get_Handle() { }

	public Byte[] GetBytes(bool include_private_bits) { }

	private static int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	private static void mono_btls_key_free(IntPtr handle) { }

	private static int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits) { }

	private static IntPtr mono_btls_key_new() { }

	private static IntPtr mono_btls_key_up_ref(IntPtr handle) { }

}

