namespace Mono.Btls;

internal abstract class MonoBtlsObject : IDisposable
{
	private abstract class MonoBtlsHandle : SafeHandle
	{

		public virtual bool IsInvalid
		{
			 get { } //Length: 14
		}

		internal MonoBtlsHandle(IntPtr handle, bool ownsHandle) { }

		public virtual bool get_IsInvalid() { }

	}

	private MonoBtlsHandle handle; //Field offset: 0x10
	private Exception lastError; //Field offset: 0x18

	internal MonoBtlsHandle Handle
	{
		internal get { } //Length: 26
	}

	public bool IsValid
	{
		 get { } //Length: 51
	}

	internal MonoBtlsObject(MonoBtlsHandle handle) { }

	protected void CheckError(bool ok, string callerName = null) { }

	protected void CheckError(int ret, string callerName = null) { }

	protected private void CheckLastError(string callerName = null) { }

	protected void CheckThrow() { }

	protected override void Close() { }

	protected void Dispose(bool disposing) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	protected void FreeDataPtr(IntPtr data) { }

	internal MonoBtlsHandle get_Handle() { }

	public bool get_IsValid() { }

	private static void mono_btls_free(IntPtr data) { }

	protected Exception SetException(Exception ex) { }

}

