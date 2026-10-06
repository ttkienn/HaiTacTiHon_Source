namespace Mono.Btls;

internal class MonoBtlsBioMemory : MonoBtlsBio
{

	public MonoBtlsBioMemory() { }

	public Byte[] GetData() { }

	private static int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data) { }

	private static IntPtr mono_btls_bio_mem_new() { }

}

