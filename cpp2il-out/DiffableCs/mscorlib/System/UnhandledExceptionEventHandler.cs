namespace System;

public sealed class UnhandledExceptionEventHandler : MulticastDelegate
{

	public UnhandledExceptionEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, UnhandledExceptionEventArgs e) { }

}

