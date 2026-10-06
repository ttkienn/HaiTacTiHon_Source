namespace Mono.Btls;

internal abstract class MonoBtlsX509LookupMono : MonoBtlsObject
{
	public class BoringX509LookupMonoHandle : MonoBtlsHandle
	{

		public BoringX509LookupMonoHandle(IntPtr handle) { }

		protected virtual bool ReleaseHandle() { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class BySubjectFunc : MulticastDelegate
	{

		public BySubjectFunc(object object, IntPtr method) { }

		public override int Invoke(IntPtr instance, IntPtr name, out IntPtr x509_ptr) { }

	}

	private GCHandle gch; //Field offset: 0x20
	private IntPtr instance; //Field offset: 0x28
	private BySubjectFunc bySubjectFunc; //Field offset: 0x30
	private IntPtr bySubjectFuncPtr; //Field offset: 0x38
	private MonoBtlsX509Lookup lookup; //Field offset: 0x40

	internal BoringX509LookupMonoHandle Handle
	{
		internal get { } //Length: 113
	}

	internal MonoBtlsX509LookupMono() { }

	protected void AddCertificate(MonoBtlsX509 certificate) { }

	protected virtual void Close() { }

	internal BoringX509LookupMonoHandle get_Handle() { }

	internal void Install(MonoBtlsX509Lookup lookup) { }

	private static int mono_btls_x509_lookup_mono_free(IntPtr handle) { }

	private static void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func) { }

	private static IntPtr mono_btls_x509_lookup_mono_new() { }

	protected abstract MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name) { }

	[MonoPInvokeCallback(typeof(BySubjectFunc))]
	private static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr) { }

}

