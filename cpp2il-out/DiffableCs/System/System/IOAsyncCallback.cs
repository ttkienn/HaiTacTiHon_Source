namespace System;

internal sealed class IOAsyncCallback : MulticastDelegate
{

	public IOAsyncCallback(object object, IntPtr method) { }

	public override void Invoke(IOAsyncResult ioares) { }

}

