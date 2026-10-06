namespace System;

public sealed class ResolveEventHandler : MulticastDelegate
{

	public ResolveEventHandler(object object, IntPtr method) { }

	public override Assembly Invoke(object sender, ResolveEventArgs args) { }

}

