namespace System.Security.Principal;

[ComVisible(True)]
public class WindowsImpersonationContext : IDisposable
{
	private IntPtr _token; //Field offset: 0x10
	private bool undo; //Field offset: 0x18

	internal WindowsImpersonationContext(IntPtr token) { }

	private static bool CloseToken(IntPtr token) { }

	[ComVisible(False)]
	public override void Dispose() { }

	private static IntPtr DuplicateToken(IntPtr token) { }

	private static bool RevertToSelf() { }

	private static bool SetCurrentToken(IntPtr token) { }

	public void Undo() { }

}

