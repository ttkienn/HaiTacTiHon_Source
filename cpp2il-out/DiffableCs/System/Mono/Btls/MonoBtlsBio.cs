namespace Mono.Btls;

internal class MonoBtlsBio : MonoBtlsObject
{
	private class BoringBioHandle : MonoBtlsHandle
	{

		public BoringBioHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}


	protected private BoringBioHandle Handle
	{
		private get { } //Length: 117
	}

	internal MonoBtlsBio(BoringBioHandle handle) { }

	protected private BoringBioHandle get_Handle() { }

	private static void mono_btls_bio_free(IntPtr handle) { }

}

