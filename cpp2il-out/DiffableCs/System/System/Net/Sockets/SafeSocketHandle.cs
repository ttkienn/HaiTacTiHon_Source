namespace System.Net.Sockets;

internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid
{
	private static bool THROW_ON_ABORT_RETRIES; //Field offset: 0x0
	private List<Thread> blocking_threads; //Field offset: 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; //Field offset: 0x28
	private bool in_cleanup; //Field offset: 0x30

	private static SafeSocketHandle() { }

	public SafeSocketHandle(IntPtr preexistingHandle, bool ownsHandle) { }

	public void RegisterForBlockingSyscall() { }

	protected virtual bool ReleaseHandle() { }

	public void UnRegisterForBlockingSyscall() { }

}

