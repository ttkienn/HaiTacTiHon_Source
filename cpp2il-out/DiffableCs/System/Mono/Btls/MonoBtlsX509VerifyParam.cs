namespace Mono.Btls;

internal class MonoBtlsX509VerifyParam : MonoBtlsObject
{
	public class BoringX509VerifyParamHandle : MonoBtlsHandle
	{

		public BoringX509VerifyParamHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}


	public bool CanModify
	{
		 get { } //Length: 154
	}

	internal BoringX509VerifyParamHandle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsX509VerifyParam(BoringX509VerifyParamHandle handle) { }

	public MonoBtlsX509VerifyParam Copy() { }

	public bool get_CanModify() { }

	internal BoringX509VerifyParamHandle get_Handle() { }

	public static MonoBtlsX509VerifyParam GetSslClient() { }

	public static MonoBtlsX509VerifyParam GetSslServer() { }

	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false) { }

	private static int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	private static IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	private static void mono_btls_x509_verify_param_free(IntPtr handle) { }

	private static IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	private static int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	private static int mono_btls_x509_verify_param_set_time(IntPtr handle, long time) { }

	public void SetHost(string name) { }

	public void SetTime(DateTime time) { }

	private void WantToModify() { }

}

