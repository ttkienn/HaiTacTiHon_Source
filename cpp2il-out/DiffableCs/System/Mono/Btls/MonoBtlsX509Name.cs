namespace Mono.Btls;

internal class MonoBtlsX509Name : MonoBtlsObject
{
	public class BoringX509NameHandle : MonoBtlsHandle
	{
		private bool dontFree; //Field offset: 0x20

		internal BoringX509NameHandle(IntPtr handle, bool ownsHandle) { }

		protected virtual bool ReleaseHandle() { }

	}


	internal BoringX509NameHandle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsX509Name(BoringX509NameHandle handle) { }

	public static MonoBtlsX509Name CreateFromData(Byte[] data, bool use_canon_enc) { }

	internal BoringX509NameHandle get_Handle() { }

	public int GetEntryCount() { }

	public string GetEntryOid(int index) { }

	public Byte[] GetEntryOidData(int index) { }

	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	public string GetEntryValue(int index, out int tag) { }

	public long GetHash() { }

	private static void mono_btls_x509_name_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	private static int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	private static int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	private static int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	private static MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	private static int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	private static long mono_btls_x509_name_hash(IntPtr handle) { }

}

